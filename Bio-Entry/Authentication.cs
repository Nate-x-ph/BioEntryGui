using System;
using System.Drawing;
using System.Windows.Forms;
using AxWMPLib; // Ensure you have this namespace

namespace Bio_Entry
{
    public partial class Authentication : Form
    {
        // Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private Form dashboardForm; // Reference to the Dashboard form
        private AxWindowsMediaPlayer mediaPlayer; // Declare mediaPlayer for the first video
        //private AxWindowsMediaPlayer mediaPlayer2; // Declare mediaPlayer2 for the second video

        // Text Loop Variables
        private Label lblLoopingText;
        private Timer textLoopTimer;
        private string textToLoop = "Welcome! Please choose your Authentication";
        private int textPosition = 0;
        private int textWidth;  

        public string defaultTitle { get; private set; } = "Welcome bossing kumusta ang buhay-buhay!"; // Default title for the dashboard

        public Authentication(Form dashboard)
        {
            InitializeComponent();

            random = new Random();

            dashboardForm = dashboard; // Store the reference to Dashboard form

            // Initialize Timer
            timer1.Interval = 1000; // 1 second
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick; // Subscribe to Tick event

            // Subscribe to the Load event
            this.Load += Authentication_Load;

            // Set the form to fullscreen mode
            this.WindowState = FormWindowState.Maximized;

            // Handle the FormClosing event
            this.FormClosing += Authentication_FormClosing;
        }

        private void Authentication_Load(object sender, EventArgs e)
        {
            // Initialize media players
            InitializeMediaPlayer();
            //InitializeMediaPlayer2();
            // Initialize looping text
            InitializeLoopingText();
        }

        private void InitializeLoopingText()
        {
            // Create and configure the Label for looping text
            lblLoopingText = new Label();
            lblLoopingText.AutoSize = true;
            lblLoopingText.Font = new Font("Arial", 24, FontStyle.Bold);
            lblLoopingText.ForeColor = Color.White;
            lblLoopingText.BackColor = Color.Transparent; // Ensure transparency if needed
            lblLoopingText.Location = new Point(10, 20); // Adjust as needed
            welcomePanel.Controls.Add(lblLoopingText);

            // Create and configure the Timer for looping text
            textLoopTimer = new Timer();
            textLoopTimer.Interval = 50; // Update every 100 milliseconds
            textLoopTimer.Tick += TextLoopTimer_Tick;
            textLoopTimer.Start();
        }

        private void TextLoopTimer_Tick(object sender, EventArgs e)
        {
            // Update the label text to create the looping effect
            lblLoopingText.Text = textToLoop;
            textWidth = lblLoopingText.Width;

            // Update label position
            lblLoopingText.Left -= 5; // Move left by 5 pixels
            if (lblLoopingText.Right < 0)
            {
                lblLoopingText.Left = welcomePanel.ClientSize.Width; // Reset to right side
            }
        }

        

        private void InitializeMediaPlayer()
        {
            // Create and configure the first media player
            mediaPlayer = new AxWindowsMediaPlayer();
            mediaPlayer.Dock = DockStyle.Fill; // Fill the panel
            mediaPlayer.Enabled = true;

            // Add media player to panel
            panelDesktopPane.Controls.Add(mediaPlayer);

            // Configure media player
            mediaPlayer.uiMode = "none"; // Hide controls
            mediaPlayer.settings.setMode("loop", true); // Set looping
            mediaPlayer.URL = "C:\\Users\\jonathan\\source\\repos\\Bio-Entry\\Bio-Entry\\Images\\authBg.mp4"; // Set the path to your video file

            // Mute the video
            mediaPlayer.settings.mute = true;

            // Play the video
            mediaPlayer.Ctlcontrols.play();
        }

        //private void InitializeMediaPlayer2()
        //{
        //    // Create and configure the second media player
        //    mediaPlayer2 = new AxWindowsMediaPlayer();
        //    mediaPlayer2.Dock = DockStyle.Fill; // Fill the welcomePanel
        //    mediaPlayer2.Enabled = true;

        //    // Add media player to the welcomePanel
        //    welcomePanel.Controls.Add(mediaPlayer2);

        //    // Configure media player
        //    mediaPlayer2.uiMode = "none"; // Hide controls
        //    mediaPlayer2.settings.setMode("loop", true); // Set looping
        //    mediaPlayer2.URL = "C:\\Users\\jonathan\\source\\repos\\Bio-Entry\\Bio-Entry\\Images\\welcomeBg.mp4"; // Set the path to your second video file

        //    // Play the video
        //    mediaPlayer2.Ctlcontrols.play();
        //}

        private void Authentication_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Show the Dashboard form when Authentication form is closed
            dashboardForm.Show();
        }

        public void SetTitle(string title)
        {
            lblTitle.Text = title;
        }

        // Methods
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

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    titlePanel.BackColor = color;
                    logoPanel.BackColor = Themecolors.ChangeColorBrightness(color, -0.3);
                    Themecolors.PrimaryColor = color;
                    Themecolors.SecondaryColor = Themecolors.ChangeColorBrightness(color, -0.3);
                }
            }
        }

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
            ActivateButton(btnSender);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy hh:mm:ss tt");
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            // Close any active form if there is one
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null; // Clear the reference to the active form
            }

            // Reset the title to default
            lblTitle.Text = defaultTitle;

            // Optionally, you might want to reset the button states or appearance here
            DisableButton();

            // Show the main dashboard (which is this current form)
            // This step is optional as this is the current form, and it should be visible by default
            this.BringToFront();
        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {
            // Handle painting if needed
        }

        private void regBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
