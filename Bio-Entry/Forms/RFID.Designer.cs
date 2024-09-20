namespace Bio_Entry.Forms
{
    partial class RFID
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
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRFID = new System.Windows.Forms.TextBox();
            this.lblRFID = new System.Windows.Forms.Label();
            this.cmbAdmin = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.AllowDrop = true;
            this.cmbFaculty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.IntegralHeight = false;
            this.cmbFaculty.ItemHeight = 26;
            this.cmbFaculty.Location = new System.Drawing.Point(272, 355);
            this.cmbFaculty.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(312, 34);
            this.cmbFaculty.TabIndex = 27;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(634, 550);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(82, 33);
            this.closeBtn.TabIndex = 26;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(272, 501);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(311, 37);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRFID
            // 
            this.txtRFID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFID.Location = new System.Drawing.Point(271, 438);
            this.txtRFID.Margin = new System.Windows.Forms.Padding(2);
            this.txtRFID.Name = "txtRFID";
            this.txtRFID.Size = new System.Drawing.Size(313, 32);
            this.txtRFID.TabIndex = 24;
            // 
            // lblRFID
            // 
            this.lblRFID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRFID.AutoSize = true;
            this.lblRFID.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFID.Location = new System.Drawing.Point(268, 398);
            this.lblRFID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRFID.Name = "lblRFID";
            this.lblRFID.Size = new System.Drawing.Size(161, 23);
            this.lblRFID.TabIndex = 23;
            this.lblRFID.Text = "RFID Card Number:";
            // 
            // cmbAdmin
            // 
            this.cmbAdmin.AllowDrop = true;
            this.cmbAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAdmin.FormattingEnabled = true;
            this.cmbAdmin.IntegralHeight = false;
            this.cmbAdmin.ItemHeight = 26;
            this.cmbAdmin.Location = new System.Drawing.Point(272, 355);
            this.cmbAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAdmin.Name = "cmbAdmin";
            this.cmbAdmin.Size = new System.Drawing.Size(312, 34);
            this.cmbAdmin.TabIndex = 22;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(268, 315);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(105, 23);
            this.lblUser.TabIndex = 21;
            this.lblUser.Text = "Select User:";
            // 
            // cmbType
            // 
            this.cmbType.AllowDrop = true;
            this.cmbType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.IntegralHeight = false;
            this.cmbType.ItemHeight = 26;
            this.cmbType.Location = new System.Drawing.Point(271, 279);
            this.cmbType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(312, 34);
            this.cmbType.TabIndex = 20;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Select Type:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "RFID Registration Form";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImage = global::Bio_Entry.Properties.Resources.rfid_payment_line_icon_credit_debit_card_contactless_payment_from_credit_card_vector;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(350, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 147);
            this.panel1.TabIndex = 28;
            // 
            // cmbStudent
            // 
            this.cmbStudent.AllowDrop = true;
            this.cmbStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.IntegralHeight = false;
            this.cmbStudent.ItemHeight = 26;
            this.cmbStudent.Location = new System.Drawing.Point(272, 355);
            this.cmbStudent.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(312, 34);
            this.cmbStudent.TabIndex = 29;
            // 
            // RFID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 612);
            this.Controls.Add(this.cmbStudent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbFaculty);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRFID);
            this.Controls.Add(this.lblRFID);
            this.Controls.Add(this.cmbAdmin);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RFID";
            this.Text = "RFID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRFID;
        private System.Windows.Forms.Label lblRFID;
        private System.Windows.Forms.ComboBox cmbAdmin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStudent;
    }
}