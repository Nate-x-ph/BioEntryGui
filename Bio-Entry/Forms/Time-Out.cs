using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Bio_Entry.Forms
{
    public partial class Time_Out : Form
    {
        private string userId;
        private string connectionString = "server=localhost;database=bioentry;uid=root;pwd=password;"; // Your connection string

        public Time_Out(string userId)
        {
            InitializeComponent();
            this.userId = userId;

            this.Load += new EventHandler(Time_Out_Load);
            txtRFIDInput.KeyDown += new KeyEventHandler(txtRFIDInput_KeyDown);
        }

        private void Time_Out_Load(object sender, EventArgs e)
        {
            txtRFIDInput.Focus(); // Set focus to the RFID input field
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
                                    LogTimeOut(reader["faculty_id"].ToString());
                                }
                                else if (!reader.IsDBNull(reader.GetOrdinal("student_id")))
                                {
                                    lblFirstName.Text = reader["student_fname"].ToString();
                                    lblLastName.Text = reader["student_lname"].ToString();
                                    LogTimeOut(reader["student_id"].ToString());
                                }
                            }
                            else
                            {
                                MessageBox.Show("No user found for the scanned RFID.");
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

        private void LogTimeOut(string userId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    DateTime timeOut = DateTime.Now;

                    // Variable to check if the timeout was successful
                    bool isTimeoutSuccessful = false;

                    // Update faculty time out
                    string facultyUpdateQuery = @"UPDATE faculty_log 
                                           SET time_out = @timeOut 
                                           WHERE faculty_id = @userId AND (time_out IS NULL OR time_out = '')";
                    using (MySqlCommand updateCmd = new MySqlCommand(facultyUpdateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@timeOut", timeOut);
                        updateCmd.Parameters.AddWithValue("@userId", userId);
                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            isTimeoutSuccessful = true;
                        }
                        else
                        {
                            MessageBox.Show("No active faculty log found to sign out.");
                        }
                    }

                    // Update student time out if applicable
                    string studentUpdateQuery = @"UPDATE student_log 
                                           SET time_out = @timeOut 
                                           WHERE student_id = @userId AND (time_out IS NULL OR time_out = '')";
                    using (MySqlCommand updateCmd = new MySqlCommand(studentUpdateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@timeOut", timeOut);
                        updateCmd.Parameters.AddWithValue("@userId", userId);
                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            isTimeoutSuccessful = true;
                        }
                        else
                        {
                            MessageBox.Show("No active student log found to sign out.");
                        }
                    }

                    if (isTimeoutSuccessful)
                    {
                        MessageBox.Show("You have successfully signed out.");
                        // Close the current form
                        this.Close();

                        // Create and show the Authentication form
                        var authenticationForm = new Auth_Dashboard(this);
                        authenticationForm.Show(); // Show the Authentication form
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error signing out user: " + ex.Message);
                }
            }
        }

    }
}
