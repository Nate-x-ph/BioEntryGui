using System;
using System.Windows.Forms;

namespace Bio_Entry
{
    public partial class MainStartUp : Form
    {
        private Timer timer;

        public MainStartUp()
        {
            InitializeComponent();

            // Set the form to fullscreen mode
            this.WindowState = FormWindowState.Maximized;

            // Set the video URL (adjust the path to your video)
            string videoPath = @"C:\Users\jonathan\source\repos\Bio-Entry\Bio-Entry\Images\bgVid.mp4"; // Change this path to your actual video

            // Set the media player to fill the form
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;

            // Hide the controls (play, pause buttons)
            axWindowsMediaPlayer1.uiMode = "none"; // This hides the control buttons

            // Check if the video file exists
            if (System.IO.File.Exists(videoPath))
            {
                // Load the video into the media player
                axWindowsMediaPlayer1.URL = videoPath;
            }
            else
            {
                MessageBox.Show("Video file not found!");
            }

            // Automatically start playing the video
            axWindowsMediaPlayer1.Ctlcontrols.play();

            // Setup the timer
            timer = new Timer();
            timer.Interval = 7000; // Show Startup for 7 seconds, adjust as needed
            timer.Tick += Timer_Tick;

            // Connect the Shown event handler
            this.Shown += MainStartUp_Shown;
        }

        private void MainStartUp_Shown(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            try
            {
                // Switch to the Dashboard form
                Dashboard dashboard = new Dashboard();
                dashboard.Show();

                // Hide the Startup form instead of closing it
                this.Hide();

                // Alternatively, if you want to completely exit the application, use Application.ExitThread();
                // Application.ExitThread();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying dashboard: " + ex.Message);
            }
        }
    }
}
