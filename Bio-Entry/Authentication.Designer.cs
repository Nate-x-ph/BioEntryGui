namespace Bio_Entry
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentication));
            this.navPanel = new System.Windows.Forms.Panel();
            this.authBtn = new System.Windows.Forms.Button();
            this.regBtn = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.homeBtn = new System.Windows.Forms.Button();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.welcomePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.navPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            this.welcomePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.navPanel.Controls.Add(this.authBtn);
            this.navPanel.Controls.Add(this.regBtn);
            this.navPanel.Controls.Add(this.logoPanel);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(366, 683);
            this.navPanel.TabIndex = 1;
            // 
            // authBtn
            // 
            this.authBtn.FlatAppearance.BorderSize = 0;
            this.authBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.authBtn.Location = new System.Drawing.Point(0, 325);
            this.authBtn.Name = "authBtn";
            this.authBtn.Size = new System.Drawing.Size(366, 70);
            this.authBtn.TabIndex = 2;
            this.authBtn.Text = "RFID";
            this.authBtn.UseVisualStyleBackColor = true;
            // 
            // regBtn
            // 
            this.regBtn.FlatAppearance.BorderSize = 0;
            this.regBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBtn.ForeColor = System.Drawing.Color.White;
            this.regBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.regBtn.Location = new System.Drawing.Point(0, 249);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(366, 70);
            this.regBtn.TabIndex = 1;
            this.regBtn.Text = "Pincode";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.DarkBlue;
            this.logoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPanel.BackgroundImage")));
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPanel.Controls.Add(this.panel3);
            this.logoPanel.Controls.Add(this.homeBtn);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(366, 195);
            this.logoPanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(-9, -4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 16);
            this.panel3.TabIndex = 1;
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.homeBtn.BackgroundImage = global::Bio_Entry.Properties.Resources.BioEntryLogo;
            this.homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Location = new System.Drawing.Point(14, -17);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(338, 246);
            this.homeBtn.TabIndex = 0;
            this.homeBtn.UseVisualStyleBackColor = false;
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktopPane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelDesktopPane.Controls.Add(this.welcomePanel);
            this.panelDesktopPane.Controls.Add(this.panel2);
            this.panelDesktopPane.Controls.Add(this.panel1);
            this.panelDesktopPane.Location = new System.Drawing.Point(366, 37);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(942, 646);
            this.panelDesktopPane.TabIndex = 3;
            // 
            // welcomePanel
            // 
            this.welcomePanel.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.welcomePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.welcomePanel.Controls.Add(this.label1);
            this.welcomePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcomePanel.Location = new System.Drawing.Point(0, 37);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(942, 101);
            this.welcomePanel.TabIndex = 5;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Controls.Add(this.lblTimer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(942, 37);
            this.panel2.TabIndex = 4;
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTimer.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(538, 5);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(80, 24);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "00:00:00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 609);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 37);
            this.panel1.TabIndex = 2;
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.titlePanel.Controls.Add(this.lblTitle);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(366, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(942, 37);
            this.titlePanel.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(14, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(451, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome bossing kumusta ang buhay-buhay!";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 683);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.navPanel);
            this.Name = "Authentication";
            this.Text = "Authentication";
            this.navPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.panelDesktopPane.ResumeLayout(false);
            this.welcomePanel.ResumeLayout(false);
            this.welcomePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Button authBtn;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Panel welcomePanel;
        private System.Windows.Forms.Label label1;
    }
}