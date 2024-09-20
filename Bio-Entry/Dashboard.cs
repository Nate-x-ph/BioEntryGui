using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib; // Add this using directive for AxWindowsMediaPlayer

namespace Bio_Entry
{
    public partial class Dashboard : Form
    {
        //Fields
        private Button activeButton = null;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        //private AxWindowsMediaPlayer mediaPlayer; // Declare mediaPlayer
        public string defaultTitle { get; private set; } = "Welcome bossing kumusta ang buhay-buhay!"; // Default title for the dashboard

        public Dashboard()
        {
            InitializeComponent();

            random = new Random();

            // Add event handler
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);

            // Initialize Timer
            timer1.Interval = 1000; // 1 second
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick; // Subscribe to Tick event

            //// Subscribe to the Load event
            //this.Load += Dashboard_Load;

            // Set the form to fullscreen mode
            this.WindowState = FormWindowState.Maximized;

            // Handle the FormClosing event
            this.FormClosing += Dashboard_FormClosing;

        }

        //private void Dashboard_Load(object sender, EventArgs e)
        //{
        //    // Initialize media player
        //    InitializeMediaPlayer();
        //}

        //private void InitializeMediaPlayer()
        //{
        //    // Create and configure media player
        //    mediaPlayer = new AxWindowsMediaPlayer();
        //    mediaPlayer.Dock = DockStyle.Fill; // Fill the panel
        //    mediaPlayer.Enabled = true;

        //    // Add media player to panel
        //    panelDesktopPane.Controls.Add(mediaPlayer);

        //    // Configure media player
        //    mediaPlayer.uiMode = "none"; // Hide controls
        //    mediaPlayer.settings.setMode("loop", true); // Set looping
        //    mediaPlayer.URL = "C:\\Users\\jonathan\\source\\repos\\Bio-Entry\\Bio-Entry\\Images\\bgVid.mp4"; // Set the path to your video file

        //    // Play the video
        //    mediaPlayer.Ctlcontrols.play();
        //}
        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Exit the application when the Dashboard form is closed
            Application.Exit();
        }

        public void SetTitle(string title)
        {
            lblTitle.Text = title;
        }

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(Themecolors.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(Themecolors.ColorList.Count);
            }
            tempIndex = index;
            string color = Themecolors.ColorList[index];

            try
            {
                return ColorTranslator.FromHtml(color);
            }
            catch (Exception)
            {
                // Log or handle the error and return a default color
                return Color.Black; // Fallback color
            }
        }


        //private void ActivateButton(object btnSender)
        //{
        //    if (btnSender != null)
        //    {
        //        if (currentButton != (Button)btnSender)
        //        {
        //            DisableButton();
        //            Color color = SelectThemeColor();
        //            currentButton = (Button)btnSender;
        //            currentButton.BackColor = color;
        //            currentButton.ForeColor = Color.White;
        //            currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            titlePanel.BackColor = color;
        //            logoPanel.BackColor = Themecolors.ChangeColorBrightness(color, -0.3);
        //            Themecolors.PrimaryColor = color;
        //            Themecolors.SecondaryColor = Themecolors.ChangeColorBrightness(color, -0.3);

        //        }
        //    }
        //}

        private void DisableButton()
        {
            foreach (Control previousBtn in navPanel.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.MidnightBlue;
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }



        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                // Reset the title when the active form is closed
                lblTitle.Text = defaultTitle;
            }
            //ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            // Cast sender to Button
            Button clickedButton = sender as Button;

            // Check if the clicked button is not already the active one
            if (activeButton != clickedButton)
            {
                // Reset appearance of the previously active button
                if (activeButton != null)
                {
                    // Reset previous button's appearance (example)
                    activeButton.BackColor = SystemColors.Control; // Default color
                    activeButton.ForeColor = SystemColors.ControlText; // Default text color
                }

                // Set new active button appearance
                clickedButton.BackColor = Color.White; // Highlight color
                clickedButton.ForeColor = Color.MidnightBlue; // Highlight text color

                // Update the active button reference
                activeButton = clickedButton;
            }

            // Create an instance of the Registration form
            Forms.Registration registrationForm = new Forms.Registration(this.panelDesktopPane, this.navPanel, this.lblTitle, this.titlePanel, this.logoPanel);
            // Set the Dashboard form as the owner
            registrationForm.Owner = this;
            // Open the Registration form
            OpenChildForm(registrationForm, sender);
        }

        private void authBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of the Startup form
            Startup startupForm = new Startup();

            // Show the Startup form
            startupForm.Show();

            // Create a Timer to close the startup form after a few seconds
            Timer timer = new Timer();
            timer.Interval = 5000; // 3000 ms = 3 seconds (change this as needed)
            timer.Tick += (s, args) =>
            {
                // Stop and dispose the timer
                timer.Stop();
                timer.Dispose();

                // Close the startup form
                startupForm.Close();

                // Show the Authentication form
                Authentication authForm = new Authentication(this);
                authForm.Show();

                // Optionally, close the current form if needed
                this.Hide();
            };

            // Start the timer
            timer.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy hh:mm:ss tt");
        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        public void ResetDashboard()
        {
            // Close any active form if there is one
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null; // Clear the reference to the active form
            }

            // Reset the title to default
            lblTitle.Text = defaultTitle;

            InitializeComponent();


        }

        private void homeBtn_Click(object sender, EventArgs e)
        {

            ResetDashboard();

        }

        // Method to reset button highlights
        public void ResetButtonHighlights()
        {
            // Assuming regBtn is a button in the Dashboard form
            regBtn.BackColor = Color.MidnightBlue; // Default color
            regBtn.ForeColor = Color.White; // Default text color
        }

        private void authBtn_Click_1(object sender, EventArgs e)
        {
            // Create an instance of the Startup form
            Startup startupForm = new Startup();

            // Show the Startup form
            startupForm.Show();

            // Create a Timer to close the startup form after a few seconds
            Timer timer = new Timer();
            timer.Interval = 5000; // 3000 ms = 3 seconds (change this as needed)
            timer.Tick += (s, args) =>
            {
                // Stop and dispose the timer
                timer.Stop();
                timer.Dispose();

                // Close the startup form
                startupForm.Close();

                // Show the Authentication form
                Authentication authForm = new Authentication(this);
                authForm.Show();

                // Optionally, close the current form if needed
                this.Hide();
            };

            // Start the timer
            timer.Start();
        }
    }
}
