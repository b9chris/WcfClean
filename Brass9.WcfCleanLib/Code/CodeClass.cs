using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brass9.WcfCleanLib.Code
{
	public class CodeClass : CodeSection
	{
		public string Inheritance { get; set; }

		public Dictionary<string, CodeBlock> Properties = new Dictionary<string, CodeBlock>();

		public List<string> Chunks = new List<string>();


		public CodeClass() : base()
		{
		}

		public CodeClass(string name) : base(name)
		{
		}
	}
}
