namespace MuteOnLock
{
	partial class frmAbout
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
			this.btnClose = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.niTray = new System.Windows.Forms.NotifyIcon(this.components);
			this.cmsTray = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnMute = new System.Windows.Forms.Button();
			this.btnUnmute = new System.Windows.Forms.Button();
			this.cmsTray.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.SystemColors.Control;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Location = new System.Drawing.Point(106, 197);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 28);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "&Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(212, 91);
			this.label1.TabIndex = 3;
			this.label1.Text = "Mute On Lock by Jake Roberts.\r\n\r\nAutomatically mutes the system volume\r\nwhen the " +
				"system is locked.\r\n\r\nThen automatically unmutes the system\r\nvolume when the syst" +
				"em is unlocked again.";
			// 
			// niTray
			// 
			this.niTray.ContextMenuStrip = this.cmsTray;
			this.niTray.Icon = ((System.Drawing.Icon)(resources.GetObject("niTray.Icon")));
			this.niTray.Text = "Mute On Lock";
			this.niTray.Visible = true;
			this.niTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.niTray_MouseDoubleClick);
			// 
			// cmsTray
			// 
			this.cmsTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.cmsTray.Name = "cmsTray";
			this.cmsTray.Size = new System.Drawing.Size(101, 48);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.openToolStripMenuItem.Text = "&Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// btnMute
			// 
			this.btnMute.BackColor = System.Drawing.SystemColors.Control;
			this.btnMute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnMute.Location = new System.Drawing.Point(35, 142);
			this.btnMute.Name = "btnMute";
			this.btnMute.Size = new System.Drawing.Size(75, 28);
			this.btnMute.TabIndex = 0;
			this.btnMute.Text = "&Mute";
			this.btnMute.UseVisualStyleBackColor = true;
			this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
			// 
			// btnUnmute
			// 
			this.btnUnmute.BackColor = System.Drawing.SystemColors.Control;
			this.btnUnmute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnUnmute.Location = new System.Drawing.Point(172, 142);
			this.btnUnmute.Name = "btnUnmute";
			this.btnUnmute.Size = new System.Drawing.Size(75, 28);
			this.btnUnmute.TabIndex = 0;
			this.btnUnmute.Text = "&Unmute";
			this.btnUnmute.UseVisualStyleBackColor = true;
			this.btnUnmute.Click += new System.EventHandler(this.btnUnmute_Click);
			// 
			// frmAbout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(283, 247);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnMute);
			this.Controls.Add(this.btnUnmute);
			this.Controls.Add(this.btnClose);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmAbout";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mute On Lock";
			this.Load += new System.EventHandler(this.frmAbout_Load);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAbout_FormClosing);
			this.cmsTray.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NotifyIcon niTray;
		private System.Windows.Forms.Button btnMute;
		private System.Windows.Forms.Button btnUnmute;
		private System.Windows.Forms.ContextMenuStrip cmsTray;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
	}
}

