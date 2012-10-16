using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MoveLargeFiles
{
	public partial class frm : Form
	{
		List<string> _directories = new List<string>();
		List<string> _files = new List<string>();
		public frm()
		{
			InitializeComponent();
		}
		private void lstDirectories_DragDrop(object sender, DragEventArgs e)
		{
			Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
			if (a != null)
			{
				for (int i = 0; i < a.Length; i++)
				{
					string s = (string)a.GetValue(i);
					if (Directory.Exists(s))
					{
						AddDirectory(s);
					}
				}
			}
		}
		private void AddDirectory(string dir)
		{
			if (!Directory.Exists(dir)) { throw new Exception("Not a directory"); }
			List<string> subDirsToRemove = new List<string>();
			foreach (string d in _directories)
			{
				if (d.Equals(dir))
				{
					return;
				}
				if (d.Contains(dir))
				{
					subDirsToRemove.Add(d);
				}
				if (dir.Contains(d))
				{
					return;
				}
			}
			foreach (string d in subDirsToRemove)
			{
				_directories.Remove(d);
			}
			_directories.Add(dir);
			DirectoriesChanged();
			return;
		}
		private void DirectoriesChanged()
		{
			_directories.Sort();
			lstDirectories.Items.Clear();
			lstBigFiles.Items.Clear();
			Stack<string> totalDirectories = new Stack<string>();
			foreach (string dir in _directories)
			{
				lstDirectories.Items.Add(dir);
				totalDirectories.Push(dir);
			}
			pnlNoDirectories.Visible = (lstDirectories.Items.Count == 0);
			while (totalDirectories.Count() > 0)
			{
				string currentDir = totalDirectories.Pop();
				DirectoryInfo di = new DirectoryInfo(currentDir);
				FileInfo[] files = di.GetFiles();
				foreach (FileInfo fi in files)
				{
					float mbs = fi.Length / 1024 / 1024;
					int threashold = 2;
					try
					{
						threashold = Convert.ToInt32(txtThreashold.Text);
					}
					catch
					{
					}
					if (mbs >= threashold)
					{
						lstBigFiles.Items.Add(fi.FullName);
					}
				}
				foreach (DirectoryInfo rdi in di.GetDirectories())
				{
					totalDirectories.Push(rdi.FullName);
				}
			}
		}
		private void lstDirectories_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				string dir = (string)lstDirectories.SelectedItem;
				_directories.Remove(dir);
				DirectoriesChanged();
			}
		}
		private void txtMoveTo_DragDrop(object sender, DragEventArgs e)
		{
			Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
			if (a != null)
			{
				if (a.Length != 1) { return; }
				string dir = (string)a.GetValue(0);
				if (!Directory.Exists(dir))
				{
					MessageBox.Show("This isn't a directory");
				}
				else
				{
					txtMoveTo.Text = dir;
				}
			}
		}
		private void btnMove_Click(object sender, EventArgs e)
		{
			int count = 0;
			foreach (string item in lstBigFiles.Items)
			{
				string oldFilepath = item;
				string filename = oldFilepath.Substring(oldFilepath.LastIndexOf("\\"));
				string newFilepath = txtMoveTo.Text + filename;
				//MessageBox.Show("Will move " + oldFilepath + " to " + newFilepath);
				File.Move(oldFilepath, newFilepath);
				count++;
			}
			MessageBox.Show("Moved " + count + " file(s)");
			Application.Exit();
		}
		private void lstDirectories_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Link;
		}
		private void txtMoveTo_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Link;
		}

		private void txtThreashold_TextChanged(object sender, EventArgs e)
		{
			DirectoriesChanged();
		}

		private void pnlNoDirectories_DragDrop(object sender, DragEventArgs e)
		{
			lstDirectories_DragDrop(sender, e);
		}

		private void pnlNoDirectories_DragEnter(object sender, DragEventArgs e)
		{
			lstDirectories_DragEnter(sender, e);
		}
	}
}
