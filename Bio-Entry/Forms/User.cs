using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bio_Entry.Forms
{
    public partial class User : Form
    {
        private Form activeForm;
        private Label lblLoopingText;
        private Timer textLoopTimer;
        private string textToLoop = "Welcome! Please Tap Your Card for Attendance.";
        private int textPosition = 0;
        private int textWidth;
        private string connectionString = "server=localhost;database=bioentry;uid=root;pwd=password;"; // Your connection string
        private string currentUserId; // Add a field to store the current user's ID

        public User(string firstName, string lastName, string userId)
        {
            InitializeComponent();
            currentUserId = userId; // Set current user ID

            // Initialize Timer
            timer1.Interval = 1000; // 1 second
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick; // Subscribe to Tick event

            // Set the form to fullscreen mode
            this.WindowState = FormWindowState.Maximized;
        }

        private void User_Load(object sender, EventArgs e)
        {
            btnPanel.Visible = false;
            InitializeLoopingText();
            TimeIn();
        }
        public void TimeIn()
        {
            var timeInForm = new Forms.Time_In();
            timeInForm.ClearUserData(); // Clear user data when opening the Time_In form
            OpenChildForm(timeInForm, null); // Pass null for btnSender since it's not needed
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
            textLoopTimer.Interval = 20; // Update every 100 milliseconds
            textLoopTimer.Tick += TextLoopTimer_Tick;
            textLoopTimer.Start();
        }


        private void TextLoopTimer_Tick(object sender, EventArgs e)
        {
            // Update the label text to create the looping effect
            lblLoopingText.Text = textToLoop;
            textWidth = lblLoopingText.Width;

            // Move the label to the left
            lblLoopingText.Left -= 2; // Adjust speed by changing the value (pixels moved per tick)

            // Check if the label has completely moved out of the visible area on the left side
            if (lblLoopingText.Right < 0)
            {
                // Reset the label's position to the right side of the panel
                lblLoopingText.Left = welcomePanel.ClientSize.Width;
            }
        }


        



        private void outBtn_Click(object sender, EventArgs e)
        {
            // Open the TimeOut form
            var timeOutForm = new Forms.Time_Out(currentUserId);
            OpenChildForm(timeOutForm, sender);
        }

        
        

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        

        

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy hh:mm:ss tt");
        }
    }
}
