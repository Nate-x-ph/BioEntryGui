namespace Bio_Entry.Forms
{
    partial class FingerVerify
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StatusText = new System.Windows.Forms.TextBox();
            this.Prompt = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblVerify = new System.Windows.Forms.Label();
            this.cmbAdmin = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fImage)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusText
            // 
            this.StatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusText.Location = new System.Drawing.Point(9, 241);
            this.StatusText.Multiline = true;
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(308, 197);
            this.StatusText.TabIndex = 31;
            // 
            // Prompt
            // 
            this.Prompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prompt.Location = new System.Drawing.Point(9, 211);
            this.Prompt.Name = "Prompt";
            this.Prompt.Size = new System.Drawing.Size(308, 22);
            this.Prompt.TabIndex = 30;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(6, 185);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(70, 16);
            this.StatusLabel.TabIndex = 28;
            this.StatusLabel.Text = "[STATUS]";
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.AccessibleName = "";
            this.cmbFaculty.AllowDrop = true;
            this.cmbFaculty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.IntegralHeight = false;
            this.cmbFaculty.ItemHeight = 26;
            this.cmbFaculty.Location = new System.Drawing.Point(444, 341);
            this.cmbFaculty.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(306, 34);
            this.cmbFaculty.TabIndex = 27;
            // 
            // btnVerify
            // 
            this.btnVerify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerify.BackColor = System.Drawing.Color.ForestGreen;
            this.btnVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerify.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Location = new System.Drawing.Point(444, 437);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(302, 53);
            this.btnVerify.TabIndex = 26;
            this.btnVerify.Text = "VERIFY";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.AccessibleName = "";
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(788, 512);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(82, 33);
            this.closeBtn.TabIndex = 25;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(448, 453);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(302, 37);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            // 
            // lblVerify
            // 
            this.lblVerify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVerify.AutoSize = true;
            this.lblVerify.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerify.Location = new System.Drawing.Point(444, 387);
            this.lblVerify.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVerify.Name = "lblVerify";
            this.lblVerify.Size = new System.Drawing.Size(206, 23);
            this.lblVerify.TabIndex = 23;
            this.lblVerify.Text = "Please verify your finger.";
            // 
            // cmbAdmin
            // 
            this.cmbAdmin.AccessibleName = "";
            this.cmbAdmin.AllowDrop = true;
            this.cmbAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAdmin.FormattingEnabled = true;
            this.cmbAdmin.IntegralHeight = false;
            this.cmbAdmin.ItemHeight = 26;
            this.cmbAdmin.Location = new System.Drawing.Point(444, 341);
            this.cmbAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAdmin.Name = "cmbAdmin";
            this.cmbAdmin.Size = new System.Drawing.Size(306, 34);
            this.cmbAdmin.TabIndex = 22;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(444, 310);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(105, 23);
            this.lblUser.TabIndex = 21;
            this.lblUser.Text = "Select User:";
            // 
            // cmbType
            // 
            this.cmbType.AccessibleName = "";
            this.cmbType.AllowDrop = true;
            this.cmbType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.IntegralHeight = false;
            this.cmbType.ItemHeight = 26;
            this.cmbType.Location = new System.Drawing.Point(444, 271);
            this.cmbType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(306, 34);
            this.cmbType.TabIndex = 20;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(444, 237);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(105, 23);
            this.lblType.TabIndex = 19;
            this.lblType.Text = "Select Type:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Fingerprint Login Form";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fImage
            // 
            this.fImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fImage.Location = new System.Drawing.Point(70, 9);
            this.fImage.Name = "fImage";
            this.fImage.Size = new System.Drawing.Size(188, 169);
            this.fImage.TabIndex = 29;
            this.fImage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImage = global::Bio_Entry.Properties.Resources.images;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(444, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 147);
            this.panel1.TabIndex = 18;
            // 
            // FingerVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 562);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.Prompt);
            this.Controls.Add(this.fImage);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.cmbFaculty);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblVerify);
            this.Controls.Add(this.cmbAdmin);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FingerVerify";
            this.Text = "FingerVerify";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FingerVerify_FormClosed);
            this.Load += new System.EventHandler(this.FingerVerify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StatusText;
        private System.Windows.Forms.TextBox Prompt;
        private System.Windows.Forms.PictureBox fImage;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblVerify;
        private System.Windows.Forms.ComboBox cmbAdmin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}