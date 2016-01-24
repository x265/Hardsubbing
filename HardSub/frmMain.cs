using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HardSub
{
	public partial class frmMain : Form
	{
		string _filePath { get; set; }
		string _lang { get; set; }

		public frmMain(string filePath, string lang)
		{
			InitializeComponent();
			Icon = Properties.Resources.Burn_Disk;

			_filePath = filePath;
			_lang = lang;
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			lblVideoFile.Text = _filePath;

			txtPathDll.Text = Properties.Settings.Default.PathPlugin;
			chkUsePluginFolder.Checked = Properties.Settings.Default.UsePluginFolder;
        }

		private void txtPathSub_TextChanged(object sender, EventArgs e)
		{
			_filePath = txtPathSub.Text;
		}

		private void btnBrowseSub_Click(object sender, EventArgs e)
		{
			var GetFile = new OpenFileDialog();
			GetFile.Filter = "Supported subtitle|*.sub;*.srt;*.ssa;*.ass|"
				+ "Subtitle|*.sub|"
				+ "SubRip|*.srt|"
				+ "Sub Station Alpha|*.ssa;*.ass|"
				+ "All Files|*.*";

			GetFile.FilterIndex = 1;
			GetFile.Multiselect = false;

			if (GetFile.ShowDialog() == DialogResult.OK)
			{
				txtPathSub.Text = GetFile.FileName;
			}
		}

		private void txtPathDll_TextChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.PathPlugin = txtPathDll.Text;
		}

		private void chkUsePluginFolder_CheckedChanged(object sender, EventArgs e)
		{
			var x = chkUsePluginFolder.Checked;
			Properties.Settings.Default.UsePluginFolder = x;
			txtPathDll.Enabled = !x;
			btnBrowseDll.Enabled = !x;
		}

		private void btnBrowseDll_Click(object sender, EventArgs e)
		{
			var getFile = new OpenFileDialog();
			getFile.Filter = "AviSynth plugin|*.dll;*.avsi|"
				+ "All Files|*.*";

			getFile.FilterIndex = 1;
			getFile.Multiselect = false;

			if (getFile.ShowDialog() == DialogResult.OK)
			{
				txtPathDll.Text = getFile.FileName;
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (!File.Exists(txtPathSub.Text))
			{
				MessageBox.Show("Subtitle file not found, please enter correct path", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!chkUsePluginFolder.Checked)
			{
				if (!File.Exists(txtPathDll.Text))
				{
					MessageBox.Show("VSFilter.dll file not found, please enter correct path", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			Properties.Settings.Default.Save();

			string script = 
				$"{(chkUsePluginFolder.Checked ? "#" : string.Empty)}LoadPlugin(\"{txtPathSub.Text}\")\r\n"
				+ $"DirectShowSource(\"{_filePath}\")\r\n"
				+ $"TextSub(\"{txtPathSub.Text}\")";

			string newname = Path.GetFileNameWithoutExtension(_filePath) + ".avs";

			File.WriteAllText(newname, script, new UTF8Encoding(false));
        }

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
