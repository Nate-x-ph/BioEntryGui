namespace Bio_Entry
{
    partial class Auth_Dashboard
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
            this.navPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.homeBtn = new System.Windows.Forms.Button();
            this.pinIcon = new System.Windows.Forms.Panel();
            this.idIcon = new System.Windows.Forms.Panel();
            this.rfidBtn = new System.Windows.Forms.Button();
            this.fingerBtn = new System.Windows.Forms.Button();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.welcomePanel = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.navPanel.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            this.welcomePanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.navPanel.Controls.Add(this.label2);
            this.navPanel.Controls.Add(this.homeBtn);
            this.navPanel.Controls.Add(this.pinIcon);
            this.navPanel.Controls.Add(this.idIcon);
            this.navPanel.Controls.Add(this.rfidBtn);
            this.navPanel.Controls.Add(this.fingerBtn);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(365, 683);
            this.navPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(110, 624);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "All rights reserved 2024";
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeBtn.BackgroundImage = global::Bio_Entry.Properties.Resources.BioEntry___3D_Transparent3;
            this.homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Location = new System.Drawing.Point(-58, -5);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(480, 332);
            this.homeBtn.TabIndex = 13;
            this.homeBtn.UseVisualStyleBackColor = false;
            // 
            // pinIcon
            // 
            this.pinIcon.AutoSize = true;
            this.pinIcon.BackColor = System.Drawing.Color.Transparent;
            this.pinIcon.BackgroundImage = global::Bio_Entry.Properties.Resources.pinIcon;
            this.pinIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pinIcon.ForeColor = System.Drawing.Color.Transparent;
            this.pinIcon.Location = new System.Drawing.Point(29, 336);
            this.pinIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pinIcon.Name = "pinIcon";
            this.pinIcon.Size = new System.Drawing.Size(105, 98);
            this.pinIcon.TabIndex = 9;
            // 
            // idIcon
            // 
            this.idIcon.AutoSize = true;
            this.idIcon.BackColor = System.Drawing.Color.Transparent;
            this.idIcon.BackgroundImage = global::Bio_Entry.Properties.Resources.RFID;
            this.idIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.idIcon.ForeColor = System.Drawing.Color.Transparent;
            this.idIcon.Location = new System.Drawing.Point(27, 425);
            this.idIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idIcon.Name = "idIcon";
            this.idIcon.Size = new System.Drawing.Size(108, 89);
            this.idIcon.TabIndex = 10;
            // 
            // rfidBtn
            // 
            this.rfidBtn.FlatAppearance.BorderSize = 0;
            this.rfidBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rfidBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfidBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rfidBtn.Location = new System.Drawing.Point(107, 425);
            this.rfidBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rfidBtn.Name = "rfidBtn";
            this.rfidBtn.Size = new System.Drawing.Size(255, 70);
            this.rfidBtn.TabIndex = 11;
            this.rfidBtn.Text = "RFID";
            this.rfidBtn.UseVisualStyleBackColor = true;
            this.rfidBtn.Click += new System.EventHandler(this.rfidBtn_Click);
            // 
            // fingerBtn
            // 
            this.fingerBtn.FlatAppearance.BorderSize = 0;
            this.fingerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fingerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fingerBtn.ForeColor = System.Drawing.Color.White;
            this.fingerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fingerBtn.Location = new System.Drawing.Point(111, 350);
            this.fingerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fingerBtn.Name = "fingerBtn";
            this.fingerBtn.Size = new System.Drawing.Size(255, 70);
            this.fingerBtn.TabIndex = 12;
            this.fingerBtn.Text = "Fingerprint";
            this.fingerBtn.UseVisualStyleBackColor = true;
            this.fingerBtn.Click += new System.EventHandler(this.fingerBtn_Click);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktopPane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelDesktopPane.Controls.Add(this.welcomePanel);
            this.panelDesktopPane.Controls.Add(this.panel1);
            this.panelDesktopPane.Location = new System.Drawing.Point(365, 37);
            this.panelDesktopPane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(941, 646);
            this.panelDesktopPane.TabIndex = 3;
            // 
            // welcomePanel
            // 
            this.welcomePanel.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.welcomePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.welcomePanel.Controls.Add(this.lblTimer);
            this.welcomePanel.Controls.Add(this.label1);
            this.welcomePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcomePanel.Location = new System.Drawing.Point(0, 0);
            this.welcomePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(941, 90);
            this.welcomePanel.TabIndex = 5;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTimer.Font = new System.Drawing.Font("Calibri Light", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(771, 16);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(170, 51);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 609);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 37);
            this.panel1.TabIndex = 2;
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.titlePanel.Controls.Add(this.lblTitle);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(365, 0);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(943, 37);
            this.titlePanel.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(13, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(451, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome bossing kumusta ang buhay-buhay!";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Auth_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 683);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.navPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Auth_Dashboard";
            this.Text = "Authentication";
            this.navPanel.ResumeLayout(false);
            this.navPanel.PerformLayout();
            this.panelDesktopPane.ResumeLayout(false);
            this.welcomePanel.ResumeLayout(false);
            this.welcomePanel.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Panel welcomePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pinIcon;
        private System.Windows.Forms.Panel idIcon;
        private System.Windows.Forms.Button rfidBtn;
        private System.Windows.Forms.Button fingerBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Label label2;
    }
}