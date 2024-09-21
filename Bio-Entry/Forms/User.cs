using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            string rfidCard = ReadRFIDCard();

            string connectionString = "Datasource=localhost;database=bioentry;uid=root;pwd=password";
            string selectQuery = @"
    SELECT 
        s.fname, 
        s.lname, 
        'student' AS user_type, 
        s.student_id AS user_id,
        sch.schedule_id
    FROM 
        student s
    JOIN 
        rfid r ON s.student_id = r.student_id
    JOIN 
        schedule sch ON sch.schedule_id = sch.schedule_id
    WHERE 
        r.rfid_data = @rfid_data
    
    UNION ALL
    
    SELECT 
        f.fname, 
        f.lname, 
        'faculty' AS user_type, 
        f.faculty_id AS user_id,
        sch.schedule_id
    FROM 
        faculty f
    JOIN 
        rfid r ON f.faculty_id = r.faculty_id
    JOIN 
        schedule sch ON sch.schedule_id = sch.schedule_id
    WHERE 
        r.rfid_data = @rfid_data";

            if (!string.IsNullOrEmpty(rfidCard))
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@rfid_data", rfidCard);

                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string firstName = reader["fname"].ToString();
                                    string lastName = reader["lname"].ToString();
                                    string userType = reader["user_type"].ToString();
                                    int userId = Convert.ToInt32(reader["user_id"]);
                                    int scheduleId = Convert.ToInt32(reader["schedule_id"]); // Renamed to avoid conflict

                                    lblFirstName.Text = firstName;
                                    lblLastName.Text = lastName;

                                    // Log attendance or any other operations you need
                                    LogAttendance(userType, userId, scheduleId); // Use the renamed variable
                                }
                            }
                            else
                            {
                                MessageBox.Show("RFID card not found in the system.");
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
            else
            {
                MessageBox.Show("No RFID card detected.");
            }
        }

        // Example method to read RFID card (implementation depends on your hardware)
        private string ReadRFIDCard()
        {
            string rfidCard = null; // Initialize the variable to hold the RFID card data
            string connectionString = "Datasource=localhost;database=bioentry;uid=root;pwd=password";

            // SQL query to get the RFID data (modify as necessary for your needs)
            string selectQuery = "SELECT \r\n    r.rfid_data, \r\n    s.student_id, \r\n    f.faculty_id \r\nFROM \r\n    rfid r\r\nLEFT JOIN \r\n    student s ON r.student_id = s.student_id\r\nLEFT JOIN \r\n    faculty f ON r.faculty_id = f.faculty_id"; // Adjust the WHERE clause as needed

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    connection.Open();
                    // Execute the query and get the RFID data
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            rfidCard = reader["rfid_data"].ToString(); // Retrieve the RFID data
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

            return rfidCard; // Return the retrieved RFID data
        }



        private void LogAttendance(string userType, int userId, int scheduleId)
        {
            string connectionString = "Datasource=localhost;database=bioentry;uid=root;pwd=password";

            DateTime timeIn = DateTime.Now;
            string year = DateTime.Now.Year.ToString();

            string query = "";
            if (userType == "student")
            {
                query = "INSERT INTO student_log (student_id, schedule_id, time_in, year) VALUES (@userId, @scheduleId, @timeIn, @year)";
            }
            else if (userType == "faculty")
            {
                query = "INSERT INTO faculty_log (faculty_id, schedule_id, time_in, year) VALUES (@userId, @scheduleId, @timeIn, @year)";
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@scheduleId", scheduleId);
                cmd.Parameters.AddWithValue("@timeIn", timeIn);
                cmd.Parameters.AddWithValue("@year", year);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
      

        private string GetCurrentScheduleId(int userId)
        {
            // Logic to get the current schedule based on the user
            // Return the appropriate schedule_id
            return "some_schedule_id";
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
