using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bio_Entry.Forms
{
    public partial class User : Form
    {
        // Text Loop Variables
        private Label lblLoopingText;
        private Timer textLoopTimer;
        private string textToLoop = "Welcome to BioEntry Doorlock Security! Secured Lab, Secured Life";
        private int textPosition = 0;
        private int textWidth;
        public User(string firstName, string lastName)
        {
            InitializeComponent();
            lblFirstName.Text = firstName;
            lblLastName.Text = lastName;

            // Initialize Timer
            timer1.Interval = 1000; // 1 second
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick; // Subscribe to Tick event

            // Set the form to fullscreen mode
            this.WindowState = FormWindowState.Maximized;

            // Initialize looping text
            InitializeLoopingText();
        }

        private void User_Load(object sender, EventArgs e)
        {

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy hh:mm:ss tt");
        }
    }
}
