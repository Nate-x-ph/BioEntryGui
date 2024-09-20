using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bio_Entry.Forms
{
    public partial class RFID : Form
    {
        public RFID()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }
        private void InitializeComboBoxes()
        {
            // Set cmbType to DropDownList to make it uneditable
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAdmin.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFaculty.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;

            // Populate cmbType with "Admin", "Faculty", and "Student"
            cmbType.Items.Add("Select Role...");
            cmbType.Items.Add("Admin");
            cmbType.Items.Add("Faculty");
            cmbType.Items.Add("Student");
            cmbType.SelectedIndex = 0;  // Set default selection if needed
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();  // Close the current form
        }
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedItem.ToString() == "Select Role...")
            {
                lblUser.Visible = false;
                lblRFID.Visible = false;
                txtRFID.Visible = false;
                btnSave.Visible = false;
                cmbAdmin.Visible = false;
                cmbFaculty.Visible = false;
                cmbStudent.Visible = false;

            }
            else if (cmbType.SelectedItem.ToString() == "Admin")
            {
                PopulateAdminComboBox();
                lblUser.Visible = true;
                lblRFID.Visible = true;
                txtRFID.Visible = true;
                btnSave.Visible = true;
                cmbAdmin.Visible = true;
                cmbFaculty.Visible = false;
                cmbStudent.Visible = false;
            }
            else if (cmbType.SelectedItem.ToString() == "Faculty")
            {
                PopulateFacultyComboBox();
                lblUser.Visible = true;
                lblRFID.Visible = true;
                txtRFID.Visible = true;
                btnSave.Visible = true;
                cmbAdmin.Visible = false;
                cmbFaculty.Visible = true;
                cmbStudent.Visible = false;
            }
            else if (cmbType.SelectedItem.ToString() == "Student")
            {
                PopulateStudentComboBox();
                lblUser.Visible = true;
                lblRFID.Visible = true;
                txtRFID.Visible = true;
                btnSave.Visible = true;
                cmbAdmin.Visible = false;
                cmbFaculty.Visible = false;
                cmbStudent.Visible = true;
            }
        }
        private void PopulateAdminComboBox()
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
                        cmbAdmin.Items.Clear();  // Clear existing items
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
        private void PopulateFacultyComboBox()
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
                        cmbFaculty.Items.Clear();  // Clear existing items
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
        private void PopulateStudentComboBox()
        {
            string connectionString = "Datasource=localhost;database=bioentry;uid=root;pwd=password";
            string selectQuery = "SELECT student_id, fname, lname FROM student";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        cmbStudent.Items.Clear();
                        cmbStudent.Items.Add("Select Student...");
                        cmbStudent.SelectedIndex = 0;

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string studentName = reader.GetString("fname") + " " + reader.GetString("lname");
                                cmbStudent.Items.Add(studentName);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No data found in the Student table.");
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check if a role is selected
            if (cmbType.SelectedItem.ToString() == "Select Role...")
            {
                MessageBox.Show("Please select a valid role.");
                return;
            }

            // Check for valid Admin, Faculty, or Student selection
            if (cmbType.SelectedItem.ToString() == "Admin" && cmbAdmin.SelectedItem.ToString() == "Select Admin...")
            {
                MessageBox.Show("Please select a valid admin.");
                return;
            }

            if (cmbType.SelectedItem.ToString() == "Faculty" && cmbFaculty.SelectedItem.ToString() == "Select Faculty...")
            {
                MessageBox.Show("Please select a valid faculty.");
                return;
            }

            if (cmbType.SelectedItem.ToString() == "Student" && cmbStudent.SelectedItem.ToString() == "Select Student...")
            {
                MessageBox.Show("Please select a valid student.");
                return;
            }

            // Proceed to save RFID to the database
            SaveToDatabase();
        }

        private void SaveToDatabase()
        {
            try
            {
                string connectionString = "Datasource=localhost;database=bioentry;uid=root;pwd=password";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Check if the RFID already exists
                    string checkQuery = "SELECT COUNT(*) FROM rfid WHERE rfid_data = @rfid_data";
                    using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@rfid_data", txtRFID.Text);
                        connection.Open();

                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("This RFID is already in the system.");
                            return; // Exit the method to prevent duplicate insertion
                        }
                    }

                    // If no duplicate is found, proceed with the insertion
                    string insertQuery = "INSERT INTO rfid (admin_id, faculty_id, student_id, rfid_data) VALUES (@admin_id, @faculty_id, @student_id, @rfid_data)";
                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        // Default values for parameters
                        command.Parameters.AddWithValue("@admin_id", DBNull.Value);
                        command.Parameters.AddWithValue("@faculty_id", DBNull.Value);
                        command.Parameters.AddWithValue("@student_id", DBNull.Value);

                        // Retrieve and set the correct ID based on the selected role
                        if (cmbType.SelectedItem.ToString() == "Admin")
                        {
                            int adminId = GetAdminId(cmbAdmin.SelectedItem.ToString());
                            command.Parameters["@admin_id"].Value = adminId;
                        }
                        else if (cmbType.SelectedItem.ToString() == "Faculty")
                        {
                            int facultyId = GetFacultyId(cmbFaculty.SelectedItem.ToString());
                            command.Parameters["@faculty_id"].Value = facultyId;
                        }
                        else if (cmbType.SelectedItem.ToString() == "Student")
                        {
                            int studentId = GetStudentId(cmbStudent.SelectedItem.ToString());
                            command.Parameters["@student_id"].Value = studentId;
                        }

                        command.Parameters.AddWithValue("@rfid_data", txtRFID.Text);

                        command.ExecuteNonQuery();
                        MessageBox.Show("RFID data saved successfully!");
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


        private int GetAdminId(string adminName)
        {
            string connectionString = "Datasource=localhost;database=bioentry;uid=root;pwd=password";
            string selectQuery = "SELECT admin_id FROM admin WHERE CONCAT(fname, ' ', lname) = @adminName";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@adminName", adminName);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : throw new Exception("Admin ID not found.");
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}");
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                throw;
            }
        }

        private int GetFacultyId(string facultyName)
        {
            string connectionString = "Datasource=localhost;database=bioentry;uid=root;pwd=password";
            string selectQuery = "SELECT faculty_id FROM faculty WHERE CONCAT(fname, ' ', lname) = @facultyName";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@facultyName", facultyName);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : throw new Exception("Faculty ID not found.");
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}");
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                throw;
            }
        }

        private int GetStudentId(string studentName)
        {
            string connectionString = "Datasource=localhost;database=bioentry;uid=root;pwd=password";
            string selectQuery = "SELECT student_id FROM student WHERE CONCAT(fname, ' ', lname) = @studentName";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@studentName", studentName);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : throw new Exception("Student ID not found.");
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}");
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                throw;
            }
        }
    }
}
