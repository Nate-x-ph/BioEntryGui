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

        }

        
    }
}
