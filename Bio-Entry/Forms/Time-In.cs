using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Bio_Entry.Forms
{
    public partial class Time_In : Form
    {
        // MySQL connection string (update with your database info)
        private string connectionString = "server=localhost;database=bioentry;uid=root;pwd=password;";

        public Time_In()
        {
            InitializeComponent();
        }

        // Button click event to start RFID scan
        private void btnIn_Click(object sender, EventArgs e)
        {
            // Start reading from RFID Scanner
            string rfidData = ReadRFID(); // Wait for RFID data

            if (!string.IsNullOrEmpty(rfidData))
            {
                GetUserDetails(rfidData);
            }
            else
            {
                MessageBox.Show("No RFID card detected.");
            }
        }

        // Read RFID from scanner (this should be replaced with actual scanner logic)
        private string ReadRFID()
        {
            // Simulated method to get RFID data from the database
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT rfid_data FROM rfid ORDER BY rfid_id DESC LIMIT 1"; // Adjust as needed

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : null; // Return null if no RFID is found
                }
            }
        }

        // Retrieve user details based on RFID card data
        private void GetUserDetails(string rfidData)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
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
                            // If faculty_id is not null, it's a faculty user
                            if (!reader.IsDBNull(reader.GetOrdinal("faculty_id")))
                            {
                                string firstName = reader["faculty_fname"].ToString();
                                string lastName = reader["faculty_lname"].ToString();
                                lblFirstName.Text = firstName;
                                lblLastName.Text = lastName;

                                // Log faculty attendance
                                LogFacultyAttendance(reader["faculty_id"].ToString());
                            }
                            // If student_id is not null, it's a student user
                            else if (!reader.IsDBNull(reader.GetOrdinal("student_id")))
                            {
                                string firstName = reader["student_fname"].ToString();
                                string lastName = reader["student_lname"].ToString();
                                lblFirstName.Text = firstName;
                                lblLastName.Text = lastName;

                                // Log student attendance
                                LogStudentAttendance(reader["student_id"].ToString());
                            }
                        }
                        else
                        {
                            MessageBox.Show("No user found for the scanned RFID.");
                        }
                    }
                }
            }
        }

        // Log attendance for a faculty user
        private void LogFacultyAttendance(string facultyId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string currentYear = DateTime.Now.Year.ToString();
                DateTime timeIn = DateTime.Now;

                // Get the schedule_id related to this faculty
                string scheduleId = GetScheduleId(facultyId);

                if (!string.IsNullOrEmpty(scheduleId)) // Only proceed if a valid schedule_id is found
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

                    MessageBox.Show("Faculty attendance logged.");
                }
            }
        }

        // Log attendance for a student user
        private void LogStudentAttendance(string studentId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string currentYear = DateTime.Now.Year.ToString();
                DateTime timeIn = DateTime.Now;

                // Get the schedule_id related to this student
                string scheduleId = GetScheduleId(studentId);

                if (!string.IsNullOrEmpty(scheduleId)) // Only proceed if a valid schedule_id is found
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

                    MessageBox.Show("Student attendance logged.");
                }
            }
        }

        // Get the schedule_id for either a faculty or student based on the ID
        private string GetScheduleId(string userId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT schedule_id FROM schedule
                                 WHERE (faculty_id = @userId OR clist_id = @userId) LIMIT 1"; // Adjust as needed

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    object result = cmd.ExecuteScalar();

                    return result != null ? result.ToString() : null; // Return null if not found
                }
            }
        }
    }
}
