namespace HardSub
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.lblIntro = new System.Windows.Forms.Label();
			this.grpVideoFile = new System.Windows.Forms.GroupBox();
			this.grpSubFile = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblVideoFile = new System.Windows.Forms.Label();
			this.txtPathSub = new System.Windows.Forms.TextBox();
			this.btnBrowseSub = new System.Windows.Forms.Button();
			this.txtPathDll = new System.Windows.Forms.TextBox();
			this.btnBrowseDll = new System.Windows.Forms.Button();
			this.chkUsePluginFolder = new System.Windows.Forms.CheckBox();
			this.grpVideoFile.SuspendLayout();
			this.grpSubFile.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.Location = new System.Drawing.Point(537, 407);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(456, 407);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "&OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// lblIntro
			// 
			this.lblIntro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblIntro.Location = new System.Drawing.Point(12, 9);
			this.lblIntro.Name = "lblIntro";
			this.lblIntro.Size = new System.Drawing.Size(600, 50);
			this.lblIntro.TabIndex = 0;
			this.lblIntro.Text = "Hardsubbing is a method that \"burns in\" subtitles into the actual video portion o" +
    "f a movie. Digital hardsubs are much like subtitled VHS tapes; the subtitles can" +
    "not be turned off.";
			// 
			// grpVideoFile
			// 
			this.grpVideoFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpVideoFile.Controls.Add(this.lblVideoFile);
			this.grpVideoFile.Location = new System.Drawing.Point(12, 62);
			this.grpVideoFile.Name = "grpVideoFile";
			this.grpVideoFile.Size = new System.Drawing.Size(600, 100);
			this.grpVideoFile.TabIndex = 1;
			this.grpVideoFile.TabStop = false;
			this.grpVideoFile.Text = "&Current video file";
			// 
			// grpSubFile
			// 
			this.grpSubFile.Controls.Add(this.btnBrowseSub);
			this.grpSubFile.Controls.Add(this.txtPathSub);
			this.grpSubFile.Location = new System.Drawing.Point(12, 168);
			this.grpSubFile.Name = "grpSubFile";
			this.grpSubFile.Size = new System.Drawing.Size(600, 100);
			this.grpSubFile.TabIndex = 2;
			this.grpSubFile.TabStop = false;
			this.grpSubFile.Text = "&Subtitle file";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chkUsePluginFolder);
			this.groupBox1.Controls.Add(this.btnBrowseDll);
			this.groupBox1.Controls.Add(this.txtPathDll);
			this.groupBox1.Location = new System.Drawing.Point(12, 274);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(600, 100);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "&VSFilter.dll file location";
			// 
			// lblVideoFile
			// 
			this.lblVideoFile.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblVideoFile.Location = new System.Drawing.Point(3, 16);
			this.lblVideoFile.Name = "lblVideoFile";
			this.lblVideoFile.Size = new System.Drawing.Size(594, 81);
			this.lblVideoFile.TabIndex = 0;
			this.lblVideoFile.Text = "X:\\umaru\\kawaii.mp4";
			this.lblVideoFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtPathSub
			// 
			this.txtPathSub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPathSub.Font = new System.Drawing.Font("Tahoma", 9F);
			this.txtPathSub.Location = new System.Drawing.Point(6, 40);
			this.txtPathSub.Name = "txtPathSub";
			this.txtPathSub.Size = new System.Drawing.Size(507, 22);
			this.txtPathSub.TabIndex = 0;
			this.txtPathSub.TextChanged += new System.EventHandler(this.txtPathSub_TextChanged);
			// 
			// btnBrowseSub
			// 
			this.btnBrowseSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseSub.Location = new System.Drawing.Point(519, 39);
			this.btnBrowseSub.Name = "btnBrowseSub";
			this.btnBrowseSub.Size = new System.Drawing.Size(75, 23);
			this.btnBrowseSub.TabIndex = 1;
			this.btnBrowseSub.Text = "&Browse";
			this.btnBrowseSub.UseVisualStyleBackColor = true;
			this.btnBrowseSub.Click += new System.EventHandler(this.btnBrowseSub_Click);
			// 
			// txtPathDll
			// 
			this.txtPathDll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPathDll.Font = new System.Drawing.Font("Tahoma", 9F);
			this.txtPathDll.Location = new System.Drawing.Point(6, 40);
			this.txtPathDll.Name = "txtPathDll";
			this.txtPathDll.Size = new System.Drawing.Size(507, 22);
			this.txtPathDll.TabIndex = 0;
			this.txtPathDll.TextChanged += new System.EventHandler(this.txtPathDll_TextChanged);
			// 
			// btnBrowseDll
			// 
			this.btnBrowseDll.Location = new System.Drawing.Point(519, 39);
			this.btnBrowseDll.Name = "btnBrowseDll";
			this.btnBrowseDll.Size = new System.Drawing.Size(75, 23);
			this.btnBrowseDll.TabIndex = 1;
			this.btnBrowseDll.Text = "B&rowse";
			this.btnBrowseDll.UseVisualStyleBackColor = true;
			this.btnBrowseDll.Click += new System.EventHandler(this.btnBrowseDll_Click);
			// 
			// chkUsePluginFolder
			// 
			this.chkUsePluginFolder.AutoSize = true;
			this.chkUsePluginFolder.Location = new System.Drawing.Point(6, 68);
			this.chkUsePluginFolder.Name = "chkUsePluginFolder";
			this.chkUsePluginFolder.Size = new System.Drawing.Size(375, 17);
			this.chkUsePluginFolder.TabIndex = 2;
			this.chkUsePluginFolder.Text = "VSFilter.dll was installed on AviSynth plugin folder, thus, &no need to find.";
			this.chkUsePluginFolder.UseVisualStyleBackColor = true;
			this.chkUsePluginFolder.CheckedChanged += new System.EventHandler(this.chkUsePluginFolder_CheckedChanged);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(624, 442);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.grpSubFile);
			this.Controls.Add(this.grpVideoFile);
			this.Controls.Add(this.lblIntro);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.Font = new System.Drawing.Font("Tahoma", 8F);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hardsubbing";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.grpVideoFile.ResumeLayout(false);
			this.grpSubFile.ResumeLayout(false);
			this.grpSubFile.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label lblIntro;
		private System.Windows.Forms.GroupBox grpVideoFile;
		private System.Windows.Forms.GroupBox grpSubFile;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblVideoFile;
		private System.Windows.Forms.TextBox txtPathSub;
		private System.Windows.Forms.Button btnBrowseSub;
		private System.Windows.Forms.Button btnBrowseDll;
		private System.Windows.Forms.TextBox txtPathDll;
		private System.Windows.Forms.CheckBox chkUsePluginFolder;
	}
}

