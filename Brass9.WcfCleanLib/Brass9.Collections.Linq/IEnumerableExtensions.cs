using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brass9.Collections.Linq
{
	public static class IEnumerableExtensions
	{
		/// <summary>
		/// Fence post foreach.
		/// 
		/// Runs the before action before calling the loop action each time, except the first time.
		/// </summary>
		/// <typeparam name="T">IEnumerable type</typeparam>
		/// <param name="enumerable">this</param>
		/// <param name="before">A call to make before loopBody is called for all items except the first.</param>
		/// <param name="loopBody">The body you would normally put in a foreach statement.</param>
		public static void FencePostBefore<T>(this IEnumerable<T> enumerable, Action<T> before, Action<T> loopBody)
		{
			var enumerator = enumerable.GetEnumerator();
			if (!enumerator.MoveNext())
				return;

			loopBody(enumerator.Current);

			while (enumerator.MoveNext())
			{
				before(enumerator.Current);
				loopBody(enumerator.Current);
			}
		}

		public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> loopBody)
		{
			foreach (var t in enumerable)
				loopBody(t);
		}
	}
}
