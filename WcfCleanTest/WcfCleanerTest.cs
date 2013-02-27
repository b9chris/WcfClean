using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.IO;

using Brass9.WcfCleanLib;


namespace WcfCleanTest
{
	[TestClass]
	public class WcfCleanerTest
	{
		[TestMethod]
		public void TestClean()
		{
			string dllPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
			var dllFile = new FileInfo(dllPath);
			var projDir = dllFile.Directory.Parent.Parent;
			var samplesDirPath = projDir.FullName + @"\Samples";
			var samplePath = samplesDirPath + @"\AchResponse.cs";
			var outputPath = samplesDirPath + @"\AchResponse_Clean.cs";

			var cleaner = new WcfCleaner();
			cleaner.Clean(samplePath, outputPath);
		}
	}
}
