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
    public partial class Pincode : Form
    {
        public Pincode()
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

            // Populate cmbType with "admin" and "faculty"
            cmbType.Items.Add("Select Role...");
            cmbType.Items.Add("Admin");
            cmbType.Items.Add("Faculty");
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
                lblPincode.Visible = false;
                txtPincode.Visible = false;
                btnSave.Visible = false;
                cmbAdmin.Visible = false; // Ensure cmbAdmin is hidden
                cmbFaculty.Visible = false; // Ensure cmbFaculty is hidden
            }
            else if (cmbType.SelectedItem.ToString() == "Admin")
            {
                PopulateAdminComboBox();
                lblUser.Visible = true;
                lblPincode.Visible = true;
                txtPincode.Visible = true;
                btnSave.Visible = true;
                cmbAdmin.Visible = true; // Ensure cmbAdmin is visible
                cmbFaculty.Visible = false; // Ensure cmbFaculty is hidden
            }
            else if (cmbType.SelectedItem.ToString() == "Faculty")
            {
                PopulateFacultyComboBox();
                lblUser.Visible = true;
                lblPincode.Visible = true;
                txtPincode.Visible = true;
                btnSave.Visible = true;
                cmbFaculty.Visible = true; // Ensure cmbFaculty is visible
                cmbAdmin.Visible = false; // Ensure cmbAdmin is hidden
            }
            else
            {
                cmbAdmin.Items.Clear();  // Clear items
                cmbAdmin.Visible = false; // Hide cmbAdmin if not needed for "faculty"
                cmbFaculty.Items.Clear();  // Clear items
                cmbFaculty.Visible = false; // Hide cmbFaculty if not needed for "admin"
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check if a role is selected
            if (cmbType.SelectedItem.ToString() == "Select Role...")
            {
                MessageBox.Show("Please select a valid role.");
                return; // Exit the function if the role is not selected
            }

            // Check if Admin is selected and a valid admin is chosen
            if (cmbType.SelectedItem.ToString() == "Admin" && cmbAdmin.SelectedItem.ToString() == "Select Admin...")
            {
                MessageBox.Show("Please select a valid admin.");
                return; // Exit the function if the admin is not selected
            }

            // Check if Faculty is selected and a valid faculty is chosen
            if (cmbType.SelectedItem.ToString() == "Faculty" && cmbFaculty.SelectedItem.ToString() == "Select Faculty...")
            {
                MessageBox.Show("Please select a valid faculty.");
                return; // Exit the function if the faculty is not selected
            }

            // If all checks are passed, proceed to save to the database
            SaveToDatabase();
        }
        private void SaveToDatabase()
        {
            try
            {
                string connectionString = "Datasource=localhost;database=bioentry;uid=root;pwd=password";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string insertQuery = "INSERT INTO pincode (admin_id, faculty_id, pincode_data) VALUES (@admin_id, @faculty_id, @pincode_data)";
                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        // Default values for parameters
                        command.Parameters.AddWithValue("@admin_id", DBNull.Value);
                        command.Parameters.AddWithValue("@faculty_id", DBNull.Value);

                        // Retrieve and set the correct ID based on the selected role
                        if (cmbType.SelectedItem.ToString() == "Admin")
                        {
                            if (cmbAdmin.SelectedIndex > 0)
                            {
                                int adminId = GetAdminId(cmbAdmin.SelectedItem.ToString());
                                command.Parameters["@admin_id"].Value = adminId;
                            }
                            else
                            {
                                MessageBox.Show("Please select a valid admin.");
                                return;
                            }
                        }
                        else if (cmbType.SelectedItem.ToString() == "Faculty")
                        {
                            if (cmbFaculty.SelectedIndex > 0)
                            {
                                int facultyId = GetFacultyId(cmbFaculty.SelectedItem.ToString());
                                command.Parameters["@faculty_id"].Value = facultyId;
                            }
                            else
                            {
                                MessageBox.Show("Please select a valid faculty.");
                                return;
                            }
                        }

                        command.Parameters.AddWithValue("@pincode_data", txtPincode.Text);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data saved successfully!");
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



    }
}
