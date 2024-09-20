using DPUruNet;
using MySql.Data.MySqlClient;
using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Bio_Entry.Forms
{
    public partial class rfidAuth : Form
    {
        protected SerialPort serialPort; // Changed to protected
        public string Admin = ""; // for admin name
        public string Faculty = ""; // for faculty name
        // Declare the Timer for the delay
        private Timer delayTimer;

        public rfidAuth()
        {
            InitializeComponent();
            InitializeComboBoxes();

            txtPin.PasswordChar = '*';
        }

        private void rfidAuth_Load(object sender, EventArgs e)
        {
            Init();
        }

        protected virtual void Init()
        {
            // Initialize the serial port
            if (serialPort == null)
            {
                serialPort = new SerialPort
                {
                    PortName = "COM3",  // Adjust this to your Arduino's COM port
                    BaudRate = 9600,
                    Parity = Parity.None,
                    StopBits = StopBits.One,
                    DataBits = 8,
                    Handshake = Handshake.None,
                    Encoding = System.Text.Encoding.Default
                };
            }

            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening serial port: {ex.Message}");
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }

            this.Close();
        }

        protected void InitializeComboBoxes()
        {
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAdmin.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFaculty.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbType.Items.Add("Select Role...");
            cmbType.Items.Add("Admin");
            cmbType.Items.Add("Faculty");
            cmbType.SelectedIndex = 0;  // Set default selection
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedItem.ToString() == "Select Role...")
            {
                lblUser.Visible = lblRFID.Visible = lblVerify.Visible = txtRFID.Visible = btnVerify.Visible = txtPin.Visible = false;
                cmbAdmin.Visible = false;
                cmbFaculty.Visible = false;
            }
            else if (cmbType.SelectedItem.ToString() == "Admin")
            {
                PopulateAdminComboBox();
                lblUser.Visible = lblRFID.Visible = lblVerify.Visible = txtRFID.Visible = btnVerify.Visible = txtPin.Visible = true;
                cmbAdmin.Visible = true;
                cmbFaculty.Visible = false;
            }
            else if (cmbType.SelectedItem.ToString() == "Faculty")
            {
                PopulateFacultyComboBox();
                lblUser.Visible = lblRFID.Visible = lblVerify.Visible = txtRFID.Visible = btnVerify.Visible = txtPin.Visible = true;
                cmbFaculty.Visible = true;
                cmbAdmin.Visible = false;
            }
        }

        protected void PopulateAdminComboBox()
        {
            string connectionString = "Datasource=localhost;database=bioentry;uid=root;pwd=password";
            string selectQuery = "SELECT admin_id, fname, lname FROM admin";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        cmbAdmin.Items.Clear();
                        cmbAdmin.Items.Add("Select Admin...");
                        cmbAdmin.SelectedIndex = 0;
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string adminName = reader.GetString("fname") + " " + reader.GetString("lname");
                                cmbAdmin.Items.Add(adminName);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No data found in the Admin table.");
                        }
                    }
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        protected void PopulateFacultyComboBox()
        {
            string connectionString = "Datasource=localhost;database=bioentry;uid=root;pwd=password";
            string selectQuery = "SELECT faculty_id, fname, lname FROM faculty";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        cmbFaculty.Items.Clear();
                        cmbFaculty.Items.Add("Select Faculty...");
                        cmbFaculty.SelectedIndex = 0;
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string facultyName = reader.GetString("fname") + " " + reader.GetString("lname");
                                cmbFaculty.Items.Add(facultyName);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No data found in the faculty table.");
                        }
                    }
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void cmbAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            Admin = cmbAdmin.Text;
        }

        private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            Faculty = cmbFaculty.Text;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedItem.ToString() == "Admin" && cmbAdmin.SelectedItem != null)
            {
                string selectedAdmin = cmbAdmin.Text;
                string adminId = GetAdminId(selectedAdmin);
                VerifyRfid(adminId, "admin");
            }
            else if (cmbType.SelectedItem.ToString() == "Faculty" && cmbFaculty.SelectedItem != null)
            {
                string selectedFaculty = cmbFaculty.Text;
                string facultyId = GetFacultyId(selectedFaculty);
                VerifyRfid(facultyId, "faculty");
            }
            else
            {
                MessageBox.Show("Please select a user.");
            }
        }

        private string GetAdminId(string adminName)
        {
            string adminId = string.Empty;
            string connectionString = "Datasource=localhost;database=bioentry;uid=root;pwd=password";
            string selectQuery = "SELECT admin_id FROM admin WHERE CONCAT(fname, ' ', lname) = @adminName";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@adminName", adminName);
                    connection.Open();
                    adminId = command.ExecuteScalar()?.ToString();
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return adminId;
        }

        private string GetFacultyId(string facultyName)
        {
            string facultyId = string.Empty;
            string connectionString = "Datasource=localhost;database=bioentry;uid=root;pwd=password";
            string selectQuery = "SELECT faculty_id FROM faculty WHERE CONCAT(fname, ' ', lname) = @facultyName";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@facultyName", facultyName);
                    connection.Open();
                    facultyId = command.ExecuteScalar()?.ToString();
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return facultyId;
        }

        // Method to verify the RFID and pincode
        private void VerifyRfid(string userId, string role)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => VerifyRfid(userId, role)));
                return;
            }

            string pincode = txtPin.Text.Trim();
            string query = @"
                SELECT p.pincode_data, r.rfid_data, a.fname AS admin_fname, a.lname AS admin_lname, 
                fac.fname AS faculty_fname, fac.lname AS faculty_lname
                FROM pincode p
                JOIN rfid r ON p.admin_id = r.admin_id OR p.faculty_id = r.faculty_id
                LEFT JOIN admin a ON p.admin_id = a.admin_id
                LEFT JOIN faculty fac ON p.faculty_id = fac.faculty_id
                WHERE (p.admin_id = @admin_id OR p.faculty_id = @faculty_id)";

            string connectionString = "Datasource=localhost;database=bioentry;uid=root;pwd=password";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@admin_id", role == "admin" ? userId : (object)DBNull.Value);
                command.Parameters.AddWithValue("@faculty_id", role == "faculty" ? userId : (object)DBNull.Value);

                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string storedPincode = reader.GetString("pincode_data");
                        string firstName = role == "admin" ? reader.GetString("admin_fname") : reader.GetString("faculty_fname");
                        string lastName = role == "admin" ? reader.GetString("admin_lname") : reader.GetString("faculty_lname");

                        if (pincode == storedPincode)
                        {
                            // Update the label to indicate successful verification
                            lblStatus.Text = $"VERIFIED! Welcome {firstName} {lastName}!";
                            lblStatus.ForeColor = System.Drawing.Color.Green; // Optional: Set text color for success

                            // Signals to Arduino
                            serialPort.Write("1"); // Signal to activate buzzer
                            serialPort.Write("2"); // Signal to activate relay

                            // Initialize and configure a delay of 5 seconds
                            delayTimer = new Timer();
                            delayTimer.Interval = 1000; // 5 seconds in milliseconds
                            delayTimer.Tick += (s, e) => OpenUserFormAfterVerification(firstName, lastName); // Open form after delay
                            delayTimer.Start();
                        }
                        else
                        {
                            // Update the label to indicate invalid pincode
                            lblStatus.Text = "ERROR! Invalid Pincode";
                            lblStatus.ForeColor = System.Drawing.Color.Red; // Optional: Set text color for error

                            // Signal to Arduino for invalid pin
                            serialPort.Write("3");
                        }
                    }
                    else
                    {
                        // Update the label if no matching user is found
                        lblStatus.Text = "Please select a valid user role and enter the pincode.";
                        lblStatus.ForeColor = System.Drawing.Color.Red; // Optional: Set text color for error
                    }
                }
            }
        }

        // Method to open the User form after the 5-second delay
        private void OpenUserFormAfterVerification(string firstName, string lastName)
        {
            // Stop and dispose of the delay timer
            delayTimer.Stop();
            delayTimer.Dispose();

            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }

            // Close the current form (fingerAuth)
            this.Close();



            // Open the User form as a child form inside the parent form
            User userDetailsForm = new User(firstName, lastName);
            userDetailsForm.Show();  // Show the child form

        }

        // Method to open a child form inside the parent form
        private Form activeForm;
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
            this.Controls.Add(childForm); // Add the child form to the current form's controls
            this.Tag = childForm; // Set the tag
            childForm.BringToFront(); // Bring the child form to the front
            childForm.Show(); // Show the child form
        }
        private void rfidAuth_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
    }
}