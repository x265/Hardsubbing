using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace HardSub
{
	public partial class frmMain : Form
	{
		StringComparison IC { get { return StringComparison.InvariantCultureIgnoreCase; } }

		string _file; // API, host send current file
		string _lang; // API, host send current language code
		public string _fileavs; // API, host read this, cannot use get-set

		public frmMain(string filePath, string lang)
		{
			InitializeComponent();
			Icon = Properties.Resources.Burn_Disk;

			_file = filePath;
			_lang = lang;
			_fileavs = Path.Combine(Path.GetDirectoryName(filePath), Path.GetFileNameWithoutExtension(filePath)) + ".avs";
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			if (string.Equals(Path.GetExtension(_file), ".avs", IC))
			{
				MessageBox.Show("Please select non AviSynth script.");
				Application.Exit();
				return;
			}

			lblVideoFile.Text = _file;
			txtPathDll.Text = Properties.Settings.Default.PathPlugin;
			chkUsePluginFolder.Checked = Properties.Settings.Default.UsePluginFolder;
        }

		private void btnBrowseSub_Click(object sender, EventArgs e)
		{
			var getFile = new OpenFileDialog();
			getFile.Filter = "Supported subtitle|*.sub;*.srt;*.ssa;*.ass|"
				+ "Subtitle|*.sub|"
				+ "SubRip|*.srt|"
				+ "Sub Station Alpha|*.ssa;*.ass|"
				+ "All Files|*.*";

			getFile.FilterIndex = 1;
			getFile.Multiselect = false;

			if (getFile.ShowDialog() == DialogResult.OK)
			{
				txtPathSub.Text = getFile.FileName;
			}
		}

		private void txtPathDll_TextChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.PathPlugin = txtPathDll.Text;
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

		private void chkUsePluginFolder_CheckedChanged(object sender, EventArgs e)
		{
			var x = chkUsePluginFolder.Checked;
			Properties.Settings.Default.UsePluginFolder = x;
			txtPathDll.Enabled = !x;
			btnBrowseDll.Enabled = !x;
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
				$"{(chkUsePluginFolder.Checked ? "#" : string.Empty)}LoadPlugin(\"{txtPathDll.Text}\")\r\n"
				+ $"DirectShowSource(\"{_file}\")\r\n"
				+ $"TextSub(\"{txtPathSub.Text}\")";

			File.WriteAllText(_fileavs, script, new UTF8Encoding(false));

			DialogResult = DialogResult.OK; // tell IFME it was OK
			Close();
        }

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel; // tell IFME user cancel the action
			Close();
		}
	}
}
