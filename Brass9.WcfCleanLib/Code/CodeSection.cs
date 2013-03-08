using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brass9.WcfCleanLib.Code
{
	/// <summary>
	/// A section of code inside a namespace, like a class or enum
	/// </summary>
	public abstract class CodeSection
	{
		public string Headings { get; set; }

		public string Name { get; set; }



		public CodeSection()
		{
		}

		public CodeSection(string name)
		{
			Name = name;
		}
	}
}
