using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Brass9.WcfCleanLib;


namespace WcfClean
{
	public partial class CleanForm : Form
	{
		public CleanForm()
		{
			InitializeComponent();

			checkBox1.Checked = true;
			toggleOverwrite();

			status_Label.Text = "";
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs ev)
		{
			toggleOverwrite();
		}
		protected void toggleOverwrite()
		{
			bool isEnabled = !checkBox1.Checked;

			textBox2.Enabled = isEnabled;
			button2.Enabled = isEnabled;
		}

		private void button1_Click(object sender, EventArgs ev)
		{
			textBox1.Text = openFileDialog();
		}

		private void button2_Click(object sender, EventArgs ev)
		{
			textBox2.Text = openFileDialog();
		}

		protected string openFileDialog()
		{
			var dialog = new OpenFileDialog();
			string filename = "";
			dialog.FileOk += (sender, ev) =>
			{
				filename = dialog.FileName;
			};
			dialog.ShowDialog();
			return filename;
		}

		private void cleanup_Button_Click(object sender, EventArgs ev)
		{
			string source = stripDoubleQuotes(textBox1.Text);
			string output;
			if (checkBox1.Checked)
				output = source;
			else
				output = stripDoubleQuotes(textBox2.Text);

			if (!File.Exists(source))
			{
				status_Label.Text = "Source file does not exist.";
				return;
			}

			status_Label.Text = "Cleaning...";

			Task.Factory.StartNew(() => {
				var cleaner = new WcfCleaner();
				cleaner.Clean(source, output);

				status_Label.Invoke(new Action(() => {
					status_Label.Text = "Done.";
				}));
			});
		}

		protected string stripDoubleQuotes(string s)
		{
			if (s.StartsWith("\""))
				s = s.Substring(1);
			if (s.EndsWith("\""))
				s = s.Substring(0, s.Length - 1);
			return s;
		}
	}
}
