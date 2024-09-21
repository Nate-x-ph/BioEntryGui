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
        private Form activeForm;
        public User(string firstName, string lastName)
        {
            InitializeComponent();
            lblFirstName.Text = firstName;
            lblLastName.Text = lastName;

            // Set the form to fullscreen mode
            this.WindowState = FormWindowState.Maximized;
        }

        private void User_Load(object sender, EventArgs e)
        {
            btnPanel.Visible = false;
        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Attendance_Click(object sender, EventArgs e)
        {
            if (btnPanel.Visible == false)
            {
                btnPanel.Visible = true;
            }
            else
            {
                btnPanel.Visible = false;
            }
        }

        private void outBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to sign out?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                // Reset the title when the active form is closed
                //lblTitle.Text = defaultTitle;
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

        private void btnIn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Time_In(), sender);

            //Adder Code for fingerprint enrollment...
            Forms.Time_In InFrm = new Forms.Time_In();
            InFrm.Hide();


            if (btnOut.Visible == false)
            {
                btnOut.Visible = true;
            }
            else
            {
                btnOut.Visible = false;
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Forms.Time_Out(), sender);

            //Adder Code for fingerprint enrollment...
            Forms.Time_Out OutFrm = new Forms.Time_Out();
            OutFrm.Hide();


            if (btnIn.Visible == false)
            {
                btnIn.Visible = true;
            }
            else
            {
                btnIn.Visible = false;
            }

            
        }

       
    }
}