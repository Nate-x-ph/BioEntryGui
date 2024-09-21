using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bio_Entry.Forms
{
    public partial class Time_In : Form
    {
        private string connectionString = "server=localhost;database=bioentry;uid=root;pwd=password;";

        public Time_In()
        {
            InitializeComponent();
            this.Load += new EventHandler(Time_In_Load);
            txtRFIDInput.KeyDown += new KeyEventHandler(txtRFIDInput_KeyDown);
        }

        // Method to clear user data from labels and the input field
        public void ClearUserData()
        {
            lblFirstName.Text = string.Empty;
            lblLastName.Text = string.Empty;
            txtRFIDInput.Clear();
        }

        // Capture the RFID input from the USB reader
        private void txtRFIDInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if Enter key was pressed
            {
                string rfidData = txtRFIDInput.Text.Trim(); // Get the RFID data

                if (!string.IsNullOrEmpty(rfidData))
                {
                    GetUserDetails(rfidData); // Process the scanned RFID
                    txtRFIDInput.Clear(); // Clear the input field for the next scan
                }
                else
                {
                    MessageBox.Show("RFID scan was invalid. Please scan again.");
                }

                e.Handled = true; // Prevent default behavior (like going to next line)
                e.SuppressKeyPress = true; // Stop the 'ding' sound on Enter
            }
        }

        // Retrieve user details based on RFID card data
        private void GetUserDetails(string rfidData)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT rfid.faculty_id, rfid.student_id, 
                                        faculty.fname AS faculty_fname, faculty.lname AS faculty_lname, 
                                        student.fname AS student_fname, student.lname AS student_lname
                                     FROM rfid
                                     LEFT JOIN faculty ON rfid.faculty_id = faculty.faculty_id
                                     LEFT JOIN student ON rfid.student_id = student.student_id
                                     WHERE rfid.rfid_data = @rfidData";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@rfidData", rfidData);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (!reader.IsDBNull(reader.GetOrdinal("faculty_id")))
                                {
                                    lblFirstName.Text = reader["faculty_fname"].ToString();
                                    lblLastName.Text = reader["faculty_lname"].ToString();
                                    LogFacultyAttendance(reader["faculty_id"].ToString());
                                }
                                else if (!reader.IsDBNull(reader.GetOrdinal("student_id")))
                                {
                                    lblFirstName.Text = reader["student_fname"].ToString();
                                    lblLastName.Text = reader["student_lname"].ToString();
                                    LogStudentAttendance(reader["student_id"].ToString());
                                }
                            }
                            else
                            {
                                MessageBox.Show("No user found for the scanned RFID.");
                                ClearUserData();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving user details: " + ex.Message);
                }
            }
        }

        // Log attendance for a faculty user
        private void LogFacultyAttendance(string facultyId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string currentYear = DateTime.Now.Year.ToString();
                    DateTime timeIn = DateTime.Now;

                    string scheduleId = GetScheduleId(facultyId);

                    if (!string.IsNullOrEmpty(scheduleId))
                    {
                        string query = @"INSERT INTO faculty_log (faculty_id, schedule_id, time_in, year)
                                         VALUES (@facultyId, @scheduleId, @timeIn, @year)";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@facultyId", facultyId);
                            cmd.Parameters.AddWithValue("@scheduleId", scheduleId);
                            cmd.Parameters.AddWithValue("@timeIn", timeIn);
                            cmd.Parameters.AddWithValue("@year", currentYear);
                            cmd.ExecuteNonQuery();
                        }

                        lblSuccessMessage.Text = "Welcome Ma'am/Sir!"; // Update the success label
                        lblSuccessMessage.ForeColor = Color.Green;
                        lblSuccessMessage.Visible = true; // Make the label visible
                    }
                }
                catch (Exception ex)
                {
                    lblSuccessMessage.Text = "Record Not Found!" + ex.Message; // Display error in the label
                    lblSuccessMessage.ForeColor = Color.Red; // Set text color to red for error
                }
            }
        }

        // Log attendance for a student user
        private void LogStudentAttendance(string studentId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string currentYear = DateTime.Now.Year.ToString();
                    DateTime timeIn = DateTime.Now;

                    string scheduleId = GetScheduleId(studentId);

                    if (!string.IsNullOrEmpty(scheduleId))
                    {
                        string query = @"INSERT INTO student_log (student_id, schedule_id, time_in, year)
                                         VALUES (@studentId, @scheduleId, @timeIn, @year)";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@studentId", studentId);
                            cmd.Parameters.AddWithValue("@scheduleId", scheduleId);
                            cmd.Parameters.AddWithValue("@timeIn", timeIn);
                            cmd.Parameters.AddWithValue("@year", currentYear);
                            cmd.ExecuteNonQuery();
                        }

                        lblSuccessMessage.Text = "Welcome My Dear Student!"; // Update the success label
                        lblSuccessMessage.ForeColor = Color.Green;
                        lblSuccessMessage.Visible = true; // Make the label visible
                    }
                }
                catch (Exception ex)
                {
                    lblSuccessMessage.Text = "Record Not Found!" + ex.Message; // Display error in the label
                    lblSuccessMessage.ForeColor = Color.Red; // Set text color to red for error
                }
            }
        }

        // Get the schedule_id for either a faculty or student based on the ID
        private string GetScheduleId(string userId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT schedule_id FROM schedule
                                     WHERE (faculty_id = @userId OR clist_id = @userId) LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            return result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("No valid schedule found for the user. Attendance log cannot be created.");
                            return null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving schedule ID: " + ex.Message);
                    return null;
                }
            }
        }

        private void Time_In_Load(object sender, EventArgs e)
        {
            txtRFIDInput.Focus(); // Set focus to the RFID input field
        }

        
    }
}
