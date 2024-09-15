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
    public partial class Registration : Form
    {
        private Form activeForm = null;  // To keep track of the currently active child form
        private Panel panelDesktopPane;  // Reference to the Dashboard's panel
        public Registration(Panel dashboardPanel)
        {
            InitializeComponent();
            panelDesktopPane = dashboardPanel;  // Assign the panel from the Dashboard form
            //LoadTheme();    

            // Subscribe to hover events for buttons
            fingerBtn.MouseEnter += Button_MouseEnter;
            fingerBtn.MouseLeave += Button_MouseLeave;
            pinBtn.MouseEnter += Button_MouseEnter;
            pinBtn.MouseLeave += Button_MouseLeave;
            rfidBtn.MouseEnter += Button_MouseEnter;
            rfidBtn.MouseLeave += Button_MouseLeave;
        }

        //private void LoadTheme()
        //{
        //    foreach (Control btns in this.Controls)
        //    {
        //        if (btns.GetType() == typeof(Button))
        //        {
        //            Button btn = (Button)btns;
        //            btn.BackColor = Themecolors.PrimaryColor;
        //            btn.ForeColor = Color.White;
        //            btn.FlatAppearance.BorderColor =Themecolors.SecondaryColor;
        //        }
        //    }
        //}

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();  // Close the previously opened form if any
            }
            activeForm = childForm;  // Set the new form as the active form
            childForm.TopLevel = false;  // Make the form a non-top-level form
            childForm.FormBorderStyle = FormBorderStyle.None;  // Remove the border of the child form
            childForm.Dock = DockStyle.Fill;  // Make the form fill the entire panel

            panelDesktopPane.Controls.Add(childForm);  // Add the form to the panel
            panelDesktopPane.Tag = childForm;  // Set the tag of the panel to the form
            childForm.BringToFront();  // Bring the child form to the front
            childForm.Show();  // Show the child form

        }


        private void fingerBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Fingerprint(), sender);
        }

        private void pinBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Pincode(), sender);
        }

        private void rfidBtn_Click(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();  // Close the current form
        }

        // Event handler for mouse entering the button area
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Change the font size and style on hover
                btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size + 2, FontStyle.Bold);

                // Change the background color to blue on hover
                btn.BackColor = Color.MidnightBlue;
                btn.ForeColor = Color.White; // Optional: Change text color to white for better contrast
            }
        }

        // Event handler for mouse leaving the button area
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Revert the font size and style
                btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size - 2, FontStyle.Bold);

                // Revert the background color to default
                btn.BackColor = SystemColors.Control;
                btn.ForeColor = Color.Black; // Revert text color to default
            }
        }
    }
}
