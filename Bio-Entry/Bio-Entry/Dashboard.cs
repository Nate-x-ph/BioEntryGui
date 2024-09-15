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
    public partial class Dashboard : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
    
        public Dashboard()
        {
            InitializeComponent();

            random = new Random();

            // Initialize Timer
            timer1.Interval = 1000; // 1 second
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick; // Subscribe to Tick event
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

        private void regBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Registration(this.panelDesktopPane), sender);
        }

        private void authBtn_Click(object sender, EventArgs e)
        {
            // Pass panelDesktopPane to Authentication form
            OpenChildForm(new Forms.Authentication(this.panelDesktopPane), sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy\nhh:mm:ss tt");
        }

        
    }
}
