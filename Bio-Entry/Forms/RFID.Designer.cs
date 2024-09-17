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
            this.txtPincode = new System.Windows.Forms.TextBox();
            this.lblPincode = new System.Windows.Forms.Label();
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
            this.cmbFaculty.ItemHeight = 31;
            this.cmbFaculty.Location = new System.Drawing.Point(363, 437);
            this.cmbFaculty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(415, 39);
            this.cmbFaculty.TabIndex = 27;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(845, 677);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(109, 41);
            this.closeBtn.TabIndex = 26;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(363, 617);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(415, 46);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtPincode
            // 
            this.txtPincode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPincode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPincode.Location = new System.Drawing.Point(361, 539);
            this.txtPincode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPincode.Name = "txtPincode";
            this.txtPincode.Size = new System.Drawing.Size(416, 38);
            this.txtPincode.TabIndex = 24;
            // 
            // lblPincode
            // 
            this.lblPincode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPincode.AutoSize = true;
            this.lblPincode.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPincode.Location = new System.Drawing.Point(357, 490);
            this.lblPincode.Name = "lblPincode";
            this.lblPincode.Size = new System.Drawing.Size(194, 28);
            this.lblPincode.TabIndex = 23;
            this.lblPincode.Text = "RFID Card Number:";
            // 
            // cmbAdmin
            // 
            this.cmbAdmin.AllowDrop = true;
            this.cmbAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAdmin.FormattingEnabled = true;
            this.cmbAdmin.IntegralHeight = false;
            this.cmbAdmin.ItemHeight = 31;
            this.cmbAdmin.Location = new System.Drawing.Point(363, 437);
            this.cmbAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAdmin.Name = "cmbAdmin";
            this.cmbAdmin.Size = new System.Drawing.Size(415, 39);
            this.cmbAdmin.TabIndex = 22;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(357, 388);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(126, 28);
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
            this.cmbType.ItemHeight = 31;
            this.cmbType.Location = new System.Drawing.Point(363, 342);
            this.cmbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(415, 39);
            this.cmbType.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Select Type:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 40);
            this.label1.TabIndex = 18;
            this.label1.Text = "RFID Registration Form";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImage = global::Bio_Entry.Properties.Resources.rfid_payment_line_icon_credit_debit_card_contactless_payment_from_credit_card_vector;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(467, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 181);
            this.panel1.TabIndex = 28;
            // 
            // cmbStudent
            // 
            this.cmbStudent.AllowDrop = true;
            this.cmbStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.IntegralHeight = false;
            this.cmbStudent.ItemHeight = 31;
            this.cmbStudent.Location = new System.Drawing.Point(363, 437);
            this.cmbStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(415, 39);
            this.cmbStudent.TabIndex = 29;
            // 
            // RFID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 753);
            this.Controls.Add(this.cmbStudent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbFaculty);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPincode);
            this.Controls.Add(this.lblPincode);
            this.Controls.Add(this.cmbAdmin);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.TextBox txtPincode;
        private System.Windows.Forms.Label lblPincode;
        private System.Windows.Forms.ComboBox cmbAdmin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStudent;
    }
}