using System;
using System.Windows.Forms;
using Microsoft.Win32;
//using System.Runtime.InteropServices;
using CoreAudioApi;

namespace MuteOnLock
{
	public partial class frmAbout : Form
	{
		//[DllImport("winmm.dll")]
		//public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

		//[DllImport("winmm.dll")]
		//public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

		MMDevice defaultDevice = null;
		public frmAbout()
		{
			InitializeComponent();
			//waveOutGetVolume(IntPtr.Zero, out this.unmutedVolume);

			MMDeviceEnumerator devEnum = new MMDeviceEnumerator();
			this.defaultDevice = devEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void niTray_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.Show();
		}

		private void frmAbout_Load(object sender, EventArgs e)
		{
			SystemEvents.SessionSwitch += new SessionSwitchEventHandler(SystemEvents_SessionSwitch);
		}

		void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
		{
			switch (e.Reason)
			{
				case SessionSwitchReason.SessionLock:
					this.Mute();
					break;
				case SessionSwitchReason.SessionUnlock:
					this.Unmute();
					break;
				default:
					break;
			}
		}

		//uint unmutedVolume = 0;
		void Mute()
		{
			//waveOutGetVolume(IntPtr.Zero, out this.unmutedVolume);
			//if (this.unmutedVolume != 0) {
			//    waveOutSetVolume(IntPtr.Zero, 0);
			//}

			if (this.defaultDevice != null)
			{
				try {
					this.defaultDevice.AudioEndpointVolume.Mute = true;
				}
				catch { }
			}
		}
		void Unmute()
		{
			//if (this.unmutedVolume != 0)
			//{
			//    waveOutSetVolume(IntPtr.Zero, this.unmutedVolume);
			//}

			if (this.defaultDevice != null)
			{
				try
				{
					this.defaultDevice.AudioEndpointVolume.Mute = false;
				}
				catch { }
			}
		}

		private void btnMute_Click(object sender, EventArgs e)
		{
			this.Mute();
		}

		private void btnUnmute_Click(object sender, EventArgs e)
		{
			this.Unmute();
		}

		private void frmAbout_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing && !this.allowClose)
			{
				e.Cancel = true;
				this.Hide();
			}
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Show();
		}

		bool allowClose = false;
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.allowClose = true;
			this.Close();
		}
	}
}
