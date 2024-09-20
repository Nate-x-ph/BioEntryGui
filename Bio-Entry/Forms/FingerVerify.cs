using DPFP;
using DPFP.Capture;
using DPFP.Verification;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

namespace Bio_Entry.Forms
{
    public partial class FingerVerify : Form, DPFP.Capture.EventHandler
    {
        private DPFP.Capture.Capture Capturer;
        private DPFP.Verification.Verification Verificator;
        private DPFP.Template Template;
        protected SerialPort serialPort;

        public ComboBox CmbType => cmbType;
        public ComboBox CmbAdmin => cmbAdmin;
        public ComboBox CmbFaculty => cmbFaculty;
        public PictureBox FImage => fImage;

        private Timer clearPromptTimer;
        private Timer clearImageTimer;

        public FingerVerify()
        {
            InitializeComponent();
            InitializeComboBoxes();
            Verificator = new DPFP.Verification.Verification();
            clearPromptTimer = new Timer
            {
                Interval = 5000 // 5 seconds
            };
            clearPromptTimer.Tick += ClearPromptTimer_Tick;

            clearImageTimer = new Timer
            {
                Interval = 5000 // 5 seconds
            };
            clearImageTimer.Tick += ClearImageTimer_Tick;
        }

        private void FingerVerify_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void ClearPromptTimer_Tick(object sender, EventArgs e)
        {
            clearPromptTimer.Stop();
            SetPrompt(string.Empty, true);
            MakeReport(string.Empty);
        }

        private void ClearImageTimer_Tick(object sender, EventArgs e)
        {
            clearImageTimer.Stop();
            ClearImage();
        }

        protected void SetPrompt(string status, bool isSuccess)
        {
            this.Invoke((Action)(() =>
            {
                Prompt.Text = status;
                Prompt.ForeColor = isSuccess ? Color.Green : Color.Red;
            }));
        }

        protected void SetStatus(string status)
        {
            this.Invoke((Action)(() => StatusLabel.Text = status));
        }

        private void DrawPicture(Bitmap bitmap)
        {
            this.Invoke((Action)(() => fImage.Image = new Bitmap(bitmap, fImage.Size)));
        }

        protected virtual void Init()
        {
            // Initialize the serial port
            if (serialPort == null)
            {
                serialPort = new SerialPort
                {
                    PortName = "COM3",
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

            Capturer = new DPFP.Capture.Capture();
            if (Capturer != null)
            {
                Capturer.EventHandler = this;
            }
            else
            {
                SetPrompt("Can't initiate capture operation", false);
            }
        }

        protected virtual void Process(DPFP.Sample sample)
        {
            DrawPicture(ConvertSampleToBitmap(sample));
            DPFP.FeatureSet features = ExtractFeature(sample, DPFP.Processing.DataPurpose.Verification);

            if (features != null)
            {
                MakeReport("Fingerprint features created.");
                VerifyFingerprint(features);
            }
        }

        protected Bitmap ConvertSampleToBitmap(DPFP.Sample sample)
        {
            DPFP.Capture.SampleConversion Converter = new DPFP.Capture.SampleConversion();
            Bitmap bitmap = null;
            Converter.ConvertToPicture(sample, ref bitmap);
            return bitmap;
        }

        protected void Start()
        {
            if (Capturer != null)
            {
                try
                {
                    Capturer.StartCapture();
                }
                catch
                {
                    SetPrompt("Can't initiate capture", false);
                }
            }
        }

        protected void Stop()
        {
            if (Capturer != null)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch
                {
                    SetPrompt("Can't terminate capture", false);
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }

            SetPrompt("System is in standby mode. Waiting for new connection...", false);
            SetStatus("Ready for new connection.");
            Stop();
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
            if (cmbType.SelectedItem.ToString() == "Select Role..")
            {
                lblUser.Visible = lblVerify.Visible = btnVerify.Visible = false;
                cmbAdmin.Visible = false;
                cmbFaculty.Visible = false;
            }
            if (cmbType.SelectedItem.ToString() == "Admin")
            {
                PopulateAdminComboBox();
                lblUser.Visible = lblVerify.Visible = btnVerify.Visible = true;
                cmbAdmin.Visible = true;
                cmbFaculty.Visible = false;
            }
            else if (cmbType.SelectedItem.ToString() == "Faculty")
            {
                PopulateFacultyComboBox();
                lblUser.Visible = lblVerify.Visible = btnVerify.Visible = true;
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

        protected void MakeReport(string message)
        {
            this.Invoke((Action)(() =>
            {
                if (!string.IsNullOrEmpty(message))
                {
                    StatusText.AppendText(message + "\r\n");
                }
                else
                {
                    StatusText.Clear();
                }
            }));
        }

        protected DPFP.FeatureSet ExtractFeature(DPFP.Sample sample, DPFP.Processing.DataPurpose purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();

            Extractor.CreateFeatureSet(sample, purpose, ref feedback, ref features);

            return feedback == DPFP.Capture.CaptureFeedback.Good ? features : null;
        }

        private void VerifyFingerprint(DPFP.FeatureSet features)
        {
            if (features == null)
            {
                MessageBox.Show("Fingerprint features are not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (InvokeRequired)
            {
                Invoke(new Action(() => VerifyFingerprint(features)));
                return;
            }

            string role = CmbType.SelectedItem?.ToString();
            int userId = GetSelectedUserId();

            if (userId != -1)
            {
                string query = @"
            SELECT f.fingerprint_data, a.fname AS admin_fname, a.lname AS admin_lname, 
            fac.fname AS faculty_fname, fac.lname AS faculty_lname
            FROM fingerprint f
            LEFT JOIN admin a ON f.admin_id = a.admin_id
            LEFT JOIN faculty fac ON f.faculty_id = fac.faculty_id
            WHERE (f.admin_id = @admin_id OR f.faculty_id = @faculty_id)";

                string connectionString = "Datasource=localhost;database=bioentry;uid=root;pwd=password";

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@admin_id", role == "Admin" ? userId : (object)DBNull.Value);
                        command.Parameters.AddWithValue("@faculty_id", role == "Faculty" ? userId : (object)DBNull.Value);

                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedFingerprint = reader.GetString("fingerprint_data");

                                string firstName = role == "Admin" ? reader.GetString("admin_fname") : reader.GetString("faculty_fname");
                                string lastName = role == "Admin" ? reader.GetString("admin_lname") : reader.GetString("faculty_lname");

                                try
                                {
                                    // Convert base64 string to byte array
                                    byte[] fingerprintBytes = Convert.FromBase64String(storedFingerprint);
                                    Template = new DPFP.Template(new MemoryStream(fingerprintBytes));
                                }
                                catch (FormatException formatEx)
                                {
                                    MessageBox.Show($"Invalid fingerprint format: {formatEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();

                                try
                                {
                                    // Perform fingerprint verification
                                    Verificator.Verify(features, Template, ref result);
                                }
                                catch (System.Runtime.InteropServices.COMException comEx)
                                {
                                    MessageBox.Show($"COM Error: {comEx.Message}", "Verification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"General Error: {ex.Message}", "Verification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                if (result.Verified)
                                {
                                    SetPrompt("VERIFIED! Welcome!", true);

                                    User userDetailsForm = new User(firstName, lastName);
                                    userDetailsForm.Show();

                                    try
                                    {
                                        serialPort.Write("1"); // Signal to Arduino to activate buzzer
                                        serialPort.Write("2"); // Signal to Arduino to activate relay
                                    }
                                    catch (Exception serialEx)
                                    {
                                        MessageBox.Show($"Error communicating with Arduino: {serialEx.Message}", "Serial Port Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    SetPrompt("ERROR! Invalid fingerprint!", false);
                                    try
                                    {
                                        serialPort.Write("3"); // Signal to Arduino to activate buzzer for invalid fingerprint
                                    }
                                    catch (Exception serialEx)
                                    {
                                        MessageBox.Show($"Error communicating with Arduino: {serialEx.Message}", "Serial Port Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                SetPrompt("ERROR", false);
                                MessageBox.Show("User not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (MySqlException sqlEx)
                {
                    MessageBox.Show($"Database Error: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"General Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid user role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            clearImageTimer.Start(); // Start the timer to clear the image after 5 seconds
        }

        protected void ClearImage()
        {
            this.Invoke((Action)(() => FImage.Image = null));
        }

        private int GetSelectedUserId()
        {
            if (CmbType.SelectedItem.ToString() == "Admin")
            {
                return GetSelectedAdminId();
            }
            else if (CmbType.SelectedItem.ToString() == "Faculty")
            {
                return GetSelectedFacultyId();
            }
            return -1;
        }

        private int GetSelectedAdminId()
        {
            string selectedAdminName = CmbAdmin.SelectedItem.ToString();
            string connectionString = "Datasource=localhost;database=bioentry;uid=root;pwd=password";
            string query = "SELECT admin_id FROM admin WHERE CONCAT(fname, ' ', lname) = @adminName";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@adminName", selectedAdminName);
                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetInt32("admin_id");
                    }
                }
            }
            return -1;
        }

        private int GetSelectedFacultyId()
        {
            string selectedFacultyName = CmbFaculty.SelectedItem.ToString();
            string connectionString = "Datasource=localhost;database=bioentry;uid=root;pwd=password";
            string query = "SELECT faculty_id FROM faculty WHERE CONCAT(fname, ' ', lname) = @facultyName";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@facultyName", selectedFacultyName);
                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetInt32("faculty_id");
                    }
                }
            }
            return -1;
        }

        private void FingerVerify_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Capturer != null)
            {
                Capturer.StopCapture();
            }
        }

        public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            MakeReport("The finger sample was captured");
            SetPrompt("Scan the same fingerprint again", false);
            Process(Sample);

            // Clear the previous prompt message after 5 seconds
            clearPromptTimer.Start(); // Start the timer
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
            MakeReport(CaptureFeedback == DPFP.Capture.CaptureFeedback.Good
                ? "The quality of the fingerprint sample is good."
                : "The quality of the fingerprint sample is poor.");
        }
        private void btnVerify_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Start();
        }

        private void FingerVerify_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
    }
}
