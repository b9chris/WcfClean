using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace Brass9.Text.RegularExpressions
{
	public class RegexHelper
	{
		public static IEnumerable<Match> MatchesGeneric(string regex, string s)
		{
			return MatchesGeneric(regex, s, 0);
		}
		public static IEnumerable<Match> MatchesGeneric(string regex, string s, int startIndex)
		{
			var r = new Regex(regex);
			return MatchesGeneric(r, s, startIndex);
		}
		public static IEnumerable<Match> MatchesGeneric(Regex regex, string s)
		{
			return MatchesGeneric(regex, s, 0);
		}
		public static IEnumerable<Match> MatchesGeneric(Regex regex, string s, int startIndex)
		{
			var matches = regex.Matches(s, startIndex).Cast<Match>();
			return matches;
		}

		/// <summary>
		/// Returns the grouped captures in a regex match
		/// 
		/// Assumes only one grouped capture in the regex - doesn't work with multiple (ignores all but first)
		/// </summary>
		/// <param name="regex">A regex like "a(b)" (and not like "a(b)(c)")</param>
		/// <param name="s">A string like "ab cab blab stab"</param>
		/// <returns>An array of captures in groups only, like new string[] { "b", "b", "b", "b" }</returns>
		public static string[] ListGroups(Regex regex, string s)
		{
			return ListGroups(regex, s, 0);
		}
		public static string[] ListGroups(string regex, string s)
		{
			return ListGroups(new Regex(regex), s);
		}
		public static string[] ListGroups(Regex regex, string s, int startIndex)
		{
			var matches = MatchesGeneric(regex, s, startIndex).Select(m => m.Groups[1].Value).ToArray();
			return matches;
		}
		public static string[] ListGroups(string regex, string s, int startIndex)
		{
			return ListGroups(new Regex(regex), s, startIndex);
		}

		public static string FirstGroup(string regex, string s)
		{
			return FirstGroup(new Regex(regex), s, 0);
		}
		public static string FirstGroup(string regex, string s, int startIndex)
		{
			return FirstGroup(new Regex(regex), s, startIndex);
		}
		public static string FirstGroup(Regex regex, string s)
		{
			return FirstGroup(regex, s, 0);
		}
		public static string FirstGroup(Regex regex, string s, int startIndex)
		{
			var first = MatchesGeneric(regex, s, startIndex).Select(m => m.Groups[1].Value).FirstOrDefault();
			return first;
		}
	}
}
