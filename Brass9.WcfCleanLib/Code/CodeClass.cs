using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brass9.WcfCleanLib.Code
{
	public class CodeClass
	{
		public string Headings { get; set; }

		public string Name { get; set; }

		public string Inheritance { get; set; }

		public Dictionary<string, CodeBlock> Properties = new Dictionary<string, CodeBlock>();

		public List<string> Chunks = new List<string>();


		public CodeClass()
		{
		}

		public CodeClass(string name)
		{
			Name = name;
		}
	}
}
