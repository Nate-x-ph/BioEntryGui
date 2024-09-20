namespace Bio_Entry.Forms
{
    partial class rfidAuth
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
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.cmbAdmin = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblVerify = new System.Windows.Forms.Label();
            this.txtRFID = new System.Windows.Forms.TextBox();
            this.lblRFID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.cmbFaculty.Location = new System.Drawing.Point(515, 394);
            this.cmbFaculty.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(306, 34);
            this.cmbFaculty.TabIndex = 42;
            this.cmbFaculty.SelectedIndexChanged += new System.EventHandler(this.cmbFaculty_SelectedIndexChanged);
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
            this.cmbAdmin.Location = new System.Drawing.Point(515, 394);
            this.cmbAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAdmin.Name = "cmbAdmin";
            this.cmbAdmin.Size = new System.Drawing.Size(306, 34);
            this.cmbAdmin.TabIndex = 41;
            this.cmbAdmin.SelectedIndexChanged += new System.EventHandler(this.cmbAdmin_SelectedIndexChanged);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(515, 363);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(105, 23);
            this.lblUser.TabIndex = 40;
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
            this.cmbType.Location = new System.Drawing.Point(515, 324);
            this.cmbType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(306, 34);
            this.cmbType.TabIndex = 39;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(515, 290);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(105, 23);
            this.lblType.TabIndex = 38;
            this.lblType.Text = "Select Type:";
            // 
            // lblVerify
            // 
            this.lblVerify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVerify.AutoSize = true;
            this.lblVerify.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerify.Location = new System.Drawing.Point(515, 511);
            this.lblVerify.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVerify.Name = "lblVerify";
            this.lblVerify.Size = new System.Drawing.Size(255, 23);
            this.lblVerify.TabIndex = 36;
            this.lblVerify.Text = "Please input your PiN to verify.";
            // 
            // txtRFID
            // 
            this.txtRFID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFID.Location = new System.Drawing.Point(514, 466);
            this.txtRFID.Margin = new System.Windows.Forms.Padding(2);
            this.txtRFID.Name = "txtRFID";
            this.txtRFID.Size = new System.Drawing.Size(307, 32);
            this.txtRFID.TabIndex = 35;
            // 
            // lblRFID
            // 
            this.lblRFID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRFID.AutoSize = true;
            this.lblRFID.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFID.Location = new System.Drawing.Point(511, 437);
            this.lblRFID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRFID.Name = "lblRFID";
            this.lblRFID.Size = new System.Drawing.Size(222, 23);
            this.lblRFID.TabIndex = 34;
            this.lblRFID.Text = "Please scan your RFID Card";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 33);
            this.label1.TabIndex = 32;
            this.label1.Text = "RFID Login Form";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackgroundImage = global::Bio_Entry.Properties.Resources.rfid_payment_line_icon_credit_debit_card_contactless_payment_from_credit_card_vector;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(610, 135);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 147);
            this.panel2.TabIndex = 29;
            // 
            // closeBtn
            // 
            this.closeBtn.AccessibleName = "";
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(924, 603);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(82, 33);
            this.closeBtn.TabIndex = 47;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerify.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.Location = new System.Drawing.Point(510, 603);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(311, 37);
            this.btnVerify.TabIndex = 48;
            this.btnVerify.Text = "VERIFY";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // txtPin
            // 
            this.txtPin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPin.Location = new System.Drawing.Point(515, 539);
            this.txtPin.Margin = new System.Windows.Forms.Padding(2);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(306, 32);
            this.txtPin.TabIndex = 49;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(71, 29);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(163, 57);
            this.lblStatus.TabIndex = 50;
            this.lblStatus.Text = "Status";
            // 
            // rfidAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 694);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbFaculty);
            this.Controls.Add(this.cmbAdmin);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblVerify);
            this.Controls.Add(this.txtRFID);
            this.Controls.Add(this.lblRFID);
            this.Controls.Add(this.label1);
            this.Name = "rfidAuth";
            this.Text = "rfidAuthcs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.rfidAuth_FormClosed);
            this.Load += new System.EventHandler(this.rfidAuth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.ComboBox cmbAdmin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblVerify;
        private System.Windows.Forms.TextBox txtRFID;
        private System.Windows.Forms.Label lblRFID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label lblStatus;
    }
}