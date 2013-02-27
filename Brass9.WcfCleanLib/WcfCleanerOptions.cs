using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brass9.WcfCleanLib
{
	public class WcfCleanerOptions
	{
		/// <summary>
		/// If true, converts a private field/public property combo to a public ... { get; set; } shorthand property.
		/// 
		/// Ignored - treated as always true.
		/// </summary>
		public bool UseShorthandProperties { get; set; }

		/// <summary>
		/// Requires UseShorthandProperties to be set to true.
		/// 
		/// If true, changes the setter logic in optional properties (ones with a Specified field) to automatically set the
		/// *Specified flag to true.
		/// 
		/// Ignored - treated as always true.
		/// </summary>
		public bool AutoSetSpecified { get; set; }

		/// <summary>
		/// Looks for long-hand Type statements and removes the namespace portion, moving it to a using statement at the top
		/// of the file.
		/// 
		/// Ignored - treated as always true.
		/// </summary>
		public bool AddUsingStatements { get; set; }

		/// <summary>
		/// By default, Services generation includes an empty remarks comment on every class - removes these.
		/// </summary>
		public bool DiscardEmptyRemarks { get; set; }



		public static WcfCleanerOptions Default
		{
			get
			{
				return new WcfCleanerOptions
				{
					UseShorthandProperties = true,
					AutoSetSpecified = true,
					AddUsingStatements = true,
					DiscardEmptyRemarks = true
				};
			}
		}
	}
}
