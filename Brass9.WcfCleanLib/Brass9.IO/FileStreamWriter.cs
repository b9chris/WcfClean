using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Brass9.IO
{
	public class FileStreamWriter : IDisposable
	{
		protected FileStream stream;
		protected StreamWriter writer;

		public FileStreamWriter(string path)
		{
			stream = File.Open(path, FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
			writer = new StreamWriter(stream, Encoding.UTF8);
		}

		public FileStreamWriter Write(params string[] text)
		{
			foreach (var s in text)
				writer.Write(s);

			return this;
		}

		public FileStreamWriter WriteLine(params string[] text)
		{
			Write(text);
			writer.WriteLine();

			return this;
		}

		public void Dispose()
		{
			writer.Dispose();
			stream.Dispose();
		}
	}
}
