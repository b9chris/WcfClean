using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using Brass9.IO;
using Brass9.Text.RegularExpressions;

using Brass9.WcfCleanLib.Code;


namespace Brass9.WcfCleanLib
{
	public class WcfCleaner
	{
		public void Clean(string sourcePath)
		{
			Clean(sourcePath, sourcePath, WcfCleanerOptions.Default);
		}
		public void Clean(string sourcePath, WcfCleanerOptions options)
		{
			Clean(sourcePath, sourcePath, options);
		}
		public void Clean(string sourcePath, string outputPath)
		{
			Clean(sourcePath, outputPath, WcfCleanerOptions.Default);
		}
		public void Clean(string sourcePath, string outputPath, WcfCleanerOptions options)
		{
			string src = File.ReadAllText(sourcePath).Replace("\r", "");	// Normalize to just \n for newlines

			// 1) Gather any existing using statements, set aside
			int namespaceIndex = src.IndexOf("namespace");
			var usings = src.Substring(0, namespaceIndex);
			var usingNamespaces = new HashSet<string>(RegexHelper.ListGroups(@"using ([^;]+);", usings));

			// 2) Gather namespace, set aside
			var fileNamespace = RegexHelper.FirstGroup(@"namespace ([\w_`\$\.]+)", src, namespaceIndex);

			// 3) Begin class loop
			int index = src.IndexOf('\n', namespaceIndex + 1) + 1;

			var classes = parseClasses(src, index, usingNamespaces, options);

			// 8) Write out
			using (var text = new FileStreamWriter(outputPath))
			{
				writeFile(text, usingNamespaces, fileNamespace, classes, options);
			}
		}

		protected List<CodeClass> parseClasses(string src, int index, HashSet<string> usingNamespaces, WcfCleanerOptions options)
		{
			// TODO: Use usingNamespaces
			var classes = new List<CodeClass>();
			var classMatches = RegexHelper.MatchesGeneric("public partial class ([^ ]+) ([^{]+)? ?{", src.Substring(index));

			foreach(var classMatch in classMatches)
			{
				int prevIndex = index;
				// 4) Parse forward until finding public partial class ____
				index = src.IndexOf("public partial class ", index);

				// If we're out of classes, we're done - stop.
				if (index == -1)
					break;

				// 5) Gather preceding remarks and attributes
				string headings = gatherHeadings(src, index, prevIndex, usingNamespaces, options);

				// 6) Save class name, inheritance
				var groups = classMatch.Groups;
				var className = groups[1].Value;
				var inheritance = groups[2].Value;
				// TODO: Cleanup namespaces in inheritance, get rid of unnecessary : object

				var codeClass = new CodeClass
				{
					Headings = headings,
					Name = className,
					Inheritance = inheritance
				};

				// Count open/closing curly braces until end of class
				int startClass = 0;
				int endClass = 0;
				countCodeBraces(src, index, out startClass, out endClass);

				string classBody = src.Substring(startClass, endClass - startClass);

				// 7) Begin property/method loop
				parseCodeBlocks(classBody, codeClass, usingNamespaces, options);

				index = endClass + 1;

				classes.Add(codeClass);
			}

			return classes;
		}

		protected string gatherHeadings(string src, int index, int prevIndex, HashSet<string> usingNamespaces, WcfCleanerOptions options)
		{
			var prevLines = src.Substring(prevIndex, index - prevIndex).Split('\n');
			var emptyLineRegex = new Regex(options.DiscardEmptyRemarks ?
				@"^\s*(\{|\/\/\/ \<remarks\/\>)?$" :
				@"^\s*\{?$"
			);
			
			var attrNamespaceRegex = new Regex(@"(\s+\[)([\w_\.`\$]+)\.([^\]]+)(.+)");

			// Search backwards through preceding lines looking for an empty line or one with just an open curly brace
			int i = prevLines.Length - 2;
			for (; i >= 0; i--)
			{
				if (emptyLineRegex.IsMatch(prevLines[i]))
					break;

				if (options.AddUsingStatements)
				{
					string line = prevLines[i];
					var matches = RegexHelper.MatchesGeneric(attrNamespaceRegex, line);

					if (matches.Count() == 1)
					{
						var groups = matches.First().Groups.Cast<Group>().ToArray();

						string attrNamespace = groups[2].Value;

						string attrStatement = groups[3].Value;
						if (attrStatement.EndsWith("()"))
							attrStatement = attrStatement.Substring(0, attrStatement.Length - 2);

						prevLines[i] = groups[1].Value + attrStatement + groups[4].Value;

						if (!usingNamespaces.Contains(attrNamespace))
							usingNamespaces.Add(attrNamespace);
					}
				}
			}

			string headings = String.Join("\n", prevLines.Skip(i + 1).Take(prevLines.Length - i - 2));

			return headings;
		}

		/// <summary>
		/// </summary>
		/// <param name="src"></param>
		/// <param name="index"></param>
		/// <param name="startChunk">Position inside of/past opening curly brace</param>
		/// <param name="endChunk">Position at/before closing curly brace</param>
		protected void countCodeBraces(string src, int index, out int startChunk, out int endChunk)
		{
			// Start the loop
			index = src.IndexOf('{', index) + 1;
			startChunk = index;
			int openBraces = 1;

			while (openBraces > 0)
			{
				index = src.IndexOfAny(new char[] { '{', '}' }, index);
				if (src[index] == '{')
					openBraces++;
				else
					openBraces--;
				index++;
			}

			endChunk = index - 1;
		}

		protected void parseCodeBlocks(string src, CodeClass codeClass, HashSet<string> usingNamespaces, WcfCleanerOptions options)
		{
			var chunks = RegexHelper.MatchesGeneric(@"(public|protected) (event)? ?([\w_\.\[\]]+) ([\w_\$]+)(\()?", src);

			int index = 0;

			foreach (var chunkMatch in chunks)
			{
				int prevIndex = index;
				index = chunkMatch.Index;

				var groups = chunkMatch.Groups.Cast<Group>().ToArray();

				// event
				if (groups[2].Value == "event")
				{
					string chunk = parseChunk(index, prevIndex, src, usingNamespaces, options);
					codeClass.Chunks.Add(chunk); 
					continue;
				}

				if (groups[5].Value == "(")
				{
					string chunk = parseChunk(index, prevIndex, src, usingNamespaces, options);
					codeClass.Chunks.Add(chunk); 
					continue;
				}

				string name = groups[4].Value;
				var prop = parseProperty(groups[3].Value, name, index, prevIndex, src, usingNamespaces, options);
				codeClass.Properties.Add(name, prop);
			}
		}

		protected string parseChunk(int index, int prevIndex, string src, HashSet<string> usingNamespaces, WcfCleanerOptions options)
		{
			string headers = gatherHeadings(src, index, prevIndex, usingNamespaces, options);

			int endOfLine = src.IndexOf('\n', index);
			// if ends with semicolon it's a one-liner like an event declaration
			if (src[endOfLine - 1] == ';')
				return headers + src.Substring(index, endOfLine - index);

			int startChunk = 0;
			int endChunk = 0;
			countCodeBraces(src, index, out startChunk, out endChunk);
			return headers + src.Substring(index, endChunk - index + 1);
		}

		protected CodeProperty parseProperty(string type, string name, int index, int prevIndex, string src, HashSet<string> usingNamespaces, WcfCleanerOptions options)
		{
			string headings = gatherHeadings(src, index, prevIndex, usingNamespaces, options);
			var prop = new CodeProperty { Headings = headings, Type = type };
			return prop;
		}

		protected void writeFile(FileStreamWriter text, HashSet<string> usingNamespaces, string fileNamespace, List<CodeClass> classes, WcfCleanerOptions options)
		{
			foreach (string usingNamespace in usingNamespaces)
			{
				text.WriteLine("using ", usingNamespace, ";");
			}

			text.WriteLine();

			text.WriteLine("namespace ", fileNamespace)
				.WriteLine("{");

			foreach (var codeClass in classes)
			{
				text.WriteLine()
					.WriteLine(codeClass.Headings)
					.WriteLine("\tpublic class ", codeClass.Name, " ", codeClass.Inheritance)
					.WriteLine("\t{");

				foreach (var chunk in codeClass.Chunks)
				{
					text.WriteLine()
						.WriteLine("\t\t", chunk);
				}

				foreach (var kv in codeClass.Properties)
				{
					var prop = (CodeProperty)kv.Value;

					if (options.AutoSetSpecified && codeClass.Properties.ContainsKey(kv.Key + "Specified"))
					{
						text.WriteLine()
							.WriteLine("\t\tprotected ", prop.Type, " _", kv.Key, ";")
							.WriteLine()
							.WriteLine(prop.Headings)
							.WriteLine("\t\tpublic ", prop.Type, " ", kv.Key)
							.WriteLine("\t\t{")
							.WriteLine("\t\t\tget { return _", kv.Key, "; }")
							.WriteLine("\t\t\tset {")
							.WriteLine("\t\t\t\t_", kv.Key, " = value;")
							.WriteLine("\t\t\t\t", kv.Key, "Specified = true;")
							.WriteLine("\t\t\t}")
							.WriteLine("\t\t}");
					}
					else
					{
						text.WriteLine()
							.WriteLine(prop.Headings)
							.WriteLine("\t\tpublic ", prop.Type, " ", kv.Key, " { get; set; }");
					}
				}

				text.WriteLine("\t}");
			}

			text.WriteLine("}");
		}
	}
}
