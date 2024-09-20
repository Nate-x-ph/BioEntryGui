using DPFP;
using DPFP.Capture;
using DPUruNet;
using MySql.Data.MySqlClient;
using Mysqlx.Expr;
using Org.BouncyCastle.Pqc.Crypto.Bike;
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

    public partial class Fingerprint : Form, DPFP.Capture.EventHandler
    {
        private DPFP.Capture.Capture Capturer;
        public string Admin = ""; //for admin name
        public string Faculty = ""; //for faculty name

        // Public property to access cmbType from other classes
        public ComboBox CmbType
        {
            get { return cmbType; }
        }
        public Fingerprint()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }
        protected void SetPrompt(string status)
        {
            this.Invoke(new Function(delegate ()
            {
                Prompt.Text = status;
            }));
        }

        protected void SetStatus(string status)
        {
            this.Invoke(new Function(delegate ()
            {
                StatusLabel.Text = status;
            }));
        }

        private void DrawPicture(Bitmap bitmap)
        {
            this.Invoke(new Function(delegate ()
            {
                fImage.Image = new Bitmap(bitmap, fImage.Size);
            }));
        }

        //For ComboBox Admin
        protected void SetcmbAdmin(string value)
        {
            this.Invoke(new Function(delegate ()
            {
                cmbAdmin.Text = value;
            }));
        }
        //For Combobox Faculty
        protected void SetcmbFaculty(string value)
        {
            this.Invoke(new Function(delegate ()
            {
                cmbFaculty.Text = value;
            }));
        }

        protected virtual void Init()
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();
                if (null != Capturer)
                    Capturer.EventHandler = this; //subscribe capturer
                else
                    SetPrompt("Can't initiate capture operation");
            }
            catch
            {
                MessageBox.Show("Can't initiate capture operation");
            }
        }

        //Process

        protected virtual void Process(DPFP.Sample Sample)
        {
            DrawPicture(ConvertSampleToBitmap(Sample));
        }

        protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Converter = new DPFP.Capture.SampleConversion();
            Bitmap bitmap = null;
            Converter.ConvertToPicture(Sample, ref bitmap);
            return bitmap;
        }

        protected void Start()
        {
            if(null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    SetPrompt("Using the fingerprint reader, scan your fingerprint");
                }
                catch
                {
                    SetPrompt("Can't initiate capture");
                }
            }
        }

        protected void Stop()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch
                {
                    SetPrompt("Can't terminate capture");
                }
            }
        }

        protected void MakeReport(string message)
        {
            this.Invoke(new Function(delegate ()
            {
                StatusText.AppendText(message + "\r\n");
            }));
        }

        protected DPFP.FeatureSet ExtractFeature(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();  // Close the current form
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

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedItem.ToString() == "Select Role...")
            {
                lblUser.Visible = false;
                lblFinger.Visible = false;
                btnScan.Visible = false;
                btnSave.Visible = false;
                cmbAdmin.Visible = false; // Ensure cmbAdmin is hidden
                cmbFaculty.Visible = false; // Ensure cmbFaculty is hidden
            }
            else if (cmbType.SelectedItem.ToString() == "Admin")
            {
                PopulateAdminComboBox();
                lblUser.Visible = true;
                lblFinger.Visible = true;
                btnScan.Visible = true;
                btnSave.Visible = true;
                cmbAdmin.Visible = true; // Ensure cmbAdmin is visible
                cmbFaculty.Visible = false; // Ensure cmbFaculty is hidden
            }
            else if (cmbType.SelectedItem.ToString() == "Faculty")
            {
                PopulateFacultyComboBox();
                lblUser.Visible = true;
                lblFinger.Visible = true;
                btnScan.Visible = true;
                btnSave.Visible = true;
                cmbAdmin.Visible = false; // Ensure cmbAdmin is hidden
                cmbFaculty.Visible = true; // Ensure cmbFaculty is visible
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

        public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            MakeReport("The finger sample was captured");
            SetPrompt("Scan the same fingerprint again");
            Process(Sample);
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The finger was removed from the fingerprint reader.");
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was touched.");
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was connected.");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was disconnected.");
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
                MakeReport("The quality of the fingerprint sample is good.");
            else
                MakeReport("The quality of the fingerprint sample is poor.");
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Start();
        }

        

        private void Fingerprint_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void cmbAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            Admin = cmbAdmin.Text;

        }

        private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            Faculty = cmbFaculty.Text;
        }

        private void Fingerprint_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stop();
        }
    }
}
