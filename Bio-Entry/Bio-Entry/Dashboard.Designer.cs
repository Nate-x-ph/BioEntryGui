namespace Bio_Entry
{
    partial class Dashboard
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
            this.authBtn = new System.Windows.Forms.Button();
            this.regBtn = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.navPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
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
            this.navPanel.TabIndex = 0;
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
            this.authBtn.Text = "Authentication";
            this.authBtn.UseVisualStyleBackColor = true;
            this.authBtn.Click += new System.EventHandler(this.authBtn_Click);
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
            this.regBtn.Text = "Registration";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.DarkBlue;
            this.logoPanel.BackgroundImage = global::Bio_Entry.Properties.Resources.BioEntry;
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(366, 195);
            this.logoPanel.TabIndex = 0;
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.DarkBlue;
            this.titlePanel.Controls.Add(this.lblTitle);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(366, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(942, 37);
            this.titlePanel.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(381, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(68, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackgroundImage = global::Bio_Entry.Properties.Resources.CCS;
            this.panelDesktopPane.Controls.Add(this.label3);
            this.panelDesktopPane.Controls.Add(this.label2);
            this.panelDesktopPane.Controls.Add(this.label1);
            this.panelDesktopPane.Controls.Add(this.lblTimer);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(366, 37);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(942, 646);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTimer.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(540, 43);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(123, 37);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "00:00:00";
            this.lblTimer.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 95);
            this.label1.TabIndex = 1;
            this.label1.Text = "BioEntry";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(595, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 52);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doorlock";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(611, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 47);
            this.label3.TabIndex = 3;
            this.label3.Text = "Security";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 683);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.navPanel);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.navPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.panelDesktopPane.ResumeLayout(false);
            this.panelDesktopPane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Button authBtn;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}