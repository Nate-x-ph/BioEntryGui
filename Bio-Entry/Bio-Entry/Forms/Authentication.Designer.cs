namespace Bio_Entry.Forms
{
    partial class Authentication
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
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.rfidBtn = new System.Windows.Forms.Button();
            this.pinBtn = new System.Windows.Forms.Button();
            this.fingerBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(759, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to BioEntry Doorlock!";
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(934, 606);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(109, 41);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // rfidBtn
            // 
            this.rfidBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rfidBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfidBtn.Location = new System.Drawing.Point(475, 469);
            this.rfidBtn.Name = "rfidBtn";
            this.rfidBtn.Size = new System.Drawing.Size(362, 79);
            this.rfidBtn.TabIndex = 8;
            this.rfidBtn.Text = "RFID";
            this.rfidBtn.UseVisualStyleBackColor = true;
            this.rfidBtn.Click += new System.EventHandler(this.rfidBtn_Click);
            // 
            // pinBtn
            // 
            this.pinBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pinBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinBtn.Location = new System.Drawing.Point(475, 362);
            this.pinBtn.Name = "pinBtn";
            this.pinBtn.Size = new System.Drawing.Size(362, 79);
            this.pinBtn.TabIndex = 7;
            this.pinBtn.Text = "Pincode";
            this.pinBtn.UseVisualStyleBackColor = true;
            this.pinBtn.Click += new System.EventHandler(this.pinBtn_Click);
            // 
            // fingerBtn
            // 
            this.fingerBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fingerBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fingerBtn.Location = new System.Drawing.Point(475, 256);
            this.fingerBtn.Name = "fingerBtn";
            this.fingerBtn.Size = new System.Drawing.Size(362, 79);
            this.fingerBtn.TabIndex = 10;
            this.fingerBtn.Text = "Fingerprint";
            this.fingerBtn.UseVisualStyleBackColor = true;
            this.fingerBtn.Click += new System.EventHandler(this.fingerBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Please choose your authentication";
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 683);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fingerBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.rfidBtn);
            this.Controls.Add(this.pinBtn);
            this.Controls.Add(this.label1);
            this.Name = "Authentication";
            this.Text = "Authentication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button rfidBtn;
        private System.Windows.Forms.Button pinBtn;
        private System.Windows.Forms.Button fingerBtn;
        private System.Windows.Forms.Label label2;
    }
}