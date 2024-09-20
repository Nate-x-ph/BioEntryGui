using DPFP;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Bio_Entry.Forms
{
    public partial class Enroll : Fingerprint
    {
        public delegate void OnTemplateEventHandler(DPFP.Template template);
        public event OnTemplateEventHandler OnTemplate;

        private DPFP.Processing.Enrollment Enroller;


        protected override void Init()
        {
            base.Init();
            base.Text = "Fingerprint Enrollment";
            Enroller = new DPFP.Processing.Enrollment();
            UpdateStatus();
        }

        protected override void Process(DPFP.Sample Sample)
        {
            base.Process(Sample);

            DPFP.FeatureSet features = ExtractFeature(Sample, DPFP.Processing.DataPurpose.Enrollment);

            if (features != null)
            {
                try
                {
                    MakeReport("The fingerprint set was created.");
                    Enroller.AddFeatures(features);
                }
                finally
                {
                    UpdateStatus();

                    switch (Enroller.TemplateStatus)
                    {
                        case DPFP.Processing.Enrollment.Status.Ready:
                            {
                                MemoryStream fingerprintData = new MemoryStream();
                                Enroller.Template.Serialize(fingerprintData);
                                fingerprintData.Position = 0;
                                byte[] bytes = fingerprintData.ToArray();

                                // Convert the fingerprint byte array to Base64 string
                                string base64Fingerprint = Convert.ToBase64String(bytes);

                                try
                                {
                                    int adminId = -1;
                                    int facultyId = -1;

                                    this.Invoke((MethodInvoker)delegate
                                    {
                                        if (CmbType.SelectedItem.ToString() == "Admin")
                                        {
                                            adminId = GetAdminId(Admin);
                                        }
                                        else if (CmbType.SelectedItem.ToString() == "Faculty")
                                        {
                                            facultyId = GetFacultyId(Faculty);
                                        }

                                        // Check if the admin_id or faculty_id already exists in the database
                                        string CheckQuery = "SELECT COUNT(*) FROM fingerprint WHERE admin_id = @admin_id OR faculty_id = @faculty_id";
                                        using (MySqlConnection MyConn1 = new MySqlConnection("Datasource=localhost;database=bioentry;uid=root;pwd=password"))
                                        using (MySqlCommand CheckCommand = new MySqlCommand(CheckQuery, MyConn1))
                                        {
                                            if (adminId != -1)
                                            {
                                                CheckCommand.Parameters.AddWithValue("@admin_id", adminId);
                                                CheckCommand.Parameters.AddWithValue("@faculty_id", DBNull.Value);
                                            }
                                            else
                                            {
                                                CheckCommand.Parameters.AddWithValue("@admin_id", DBNull.Value);
                                                CheckCommand.Parameters.AddWithValue("@faculty_id", facultyId);
                                            }

                                            MyConn1.Open();
                                            int count = Convert.ToInt32(CheckCommand.ExecuteScalar());

                                            if (count > 0)
                                            {
                                                MessageBox.Show("This user has already registered fingerprint data.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                MakeReport("Duplicate entry found, fingerprint data already exists.");
                                                Stop();
                                            }
                                            else
                                            {
                                                // Insert new fingerprint data if no duplicate
                                                string InsertQuery = "INSERT INTO fingerprint (admin_id, faculty_id, fingerprint_data) VALUES (@admin_id, @faculty_id, @fingerprint_data)";
                                                using (MySqlCommand InsertCommand = new MySqlCommand(InsertQuery, MyConn1))
                                                {
                                                    InsertCommand.Parameters.AddWithValue("@fingerprint_data", base64Fingerprint).DbType = DbType.String;

                                                    if (adminId != -1)
                                                    {
                                                        InsertCommand.Parameters.AddWithValue("@admin_id", adminId);
                                                        InsertCommand.Parameters.AddWithValue("@faculty_id", DBNull.Value);
                                                    }
                                                    else
                                                    {
                                                        InsertCommand.Parameters.AddWithValue("@admin_id", DBNull.Value);
                                                        InsertCommand.Parameters.AddWithValue("@faculty_id", facultyId);
                                                    }

                                                    InsertCommand.ExecuteNonQuery();
                                                    MessageBox.Show("Fingerprint data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    MakeReport("Fingerprint data saved successfully.");
                                                    Stop();
                                                }
                                            }
                                        }
                                    });
                                }
                                catch (Exception ex)
                                {
                                    this.Invoke((MethodInvoker)delegate
                                    {
                                        MessageBox.Show("Error during validation or insertion: " + ex.Message);
                                    });
                                }

                                break;
                            }
                        case DPFP.Processing.Enrollment.Status.Failed:
                            {
                                Enroller.Clear();
                                Stop();
                                UpdateStatus();
                                OnTemplate(null);
                                Start();
                                break;
                            }
                    }
                }
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

        private void UpdateStatus()
        {
            SetStatus(string.Format("Fingerprint sample needed: {0}", Enroller.FeaturesNeeded));
        }
    }
}
