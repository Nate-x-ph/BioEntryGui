using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bio_Entry
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();

            // Automatically play the video
            PlayStartupVideo();

        }

        private void PlayStartupVideo()
        {
            // Set the video URL (adjust the path to your video)
            string videoPath = @"C:\Users\jonathan\source\repos\Bio-Entry\Bio-Entry\Images\bgVid.mp4"; // Change this path to your actual video

            // Set the media player to fill the form
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;

            // Hide the controls (play, pause buttons)
            axWindowsMediaPlayer1.uiMode = "none"; // This hides the control buttons

            // Load the video into the media player
            axWindowsMediaPlayer1.URL = videoPath;

            // Automatically start playing the video
            axWindowsMediaPlayer1.Ctlcontrols.play();

            // Set the form to fullscreen mode
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
