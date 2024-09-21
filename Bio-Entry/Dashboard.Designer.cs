﻿namespace Bio_Entry
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
            this.titlePanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.homeBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.navPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.navPanel.Controls.Add(this.label1);
            this.navPanel.Controls.Add(this.panel4);
            this.navPanel.Controls.Add(this.homeBtn);
            this.navPanel.Controls.Add(this.panel5);
            this.navPanel.Controls.Add(this.authBtn);
            this.navPanel.Controls.Add(this.regBtn);
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
            this.authBtn.Location = new System.Drawing.Point(121, 453);
            this.authBtn.Name = "authBtn";
            this.authBtn.Size = new System.Drawing.Size(244, 70);
            this.authBtn.TabIndex = 6;
            this.authBtn.Text = "Authentication";
            this.authBtn.UseVisualStyleBackColor = true;
            this.authBtn.Click += new System.EventHandler(this.authBtn_Click_1);
            // 
            // regBtn
            // 
            this.regBtn.FlatAppearance.BorderSize = 0;
            this.regBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBtn.ForeColor = System.Drawing.Color.White;
            this.regBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.regBtn.Location = new System.Drawing.Point(121, 377);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(244, 70);
            this.regBtn.TabIndex = 5;
            this.regBtn.Text = "Registration";
            this.regBtn.UseVisualStyleBackColor = true;
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.titlePanel.Controls.Add(this.lblTitle);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(366, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(942, 37);
            this.titlePanel.TabIndex = 1;
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
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(76, 629);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "All rights reserved 2024";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktopPane.BackgroundImage = global::Bio_Entry.Properties.Resources.bg3;
            this.panelDesktopPane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelDesktopPane.Controls.Add(this.panel2);
            this.panelDesktopPane.Controls.Add(this.panel1);
            this.panelDesktopPane.Location = new System.Drawing.Point(366, 37);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(942, 646);
            this.panelDesktopPane.TabIndex = 2;
            this.panelDesktopPane.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPane_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel2.Controls.Add(this.lblTimer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(942, 37);
            this.panel2.TabIndex = 3;
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
            this.lblTimer.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 609);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 37);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::Bio_Entry.Properties.Resources.regIcon;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.ForeColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(23, 377);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(92, 70);
            this.panel4.TabIndex = 7;
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeBtn.BackgroundImage = global::Bio_Entry.Properties.Resources.BioEntry___3D_Transparent3;
            this.homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Location = new System.Drawing.Point(-59, -4);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(480, 332);
            this.homeBtn.TabIndex = 0;
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::Bio_Entry.Properties.Resources.authIcon;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.ForeColor = System.Drawing.Color.Transparent;
            this.panel5.Location = new System.Drawing.Point(2, 448);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(113, 88);
            this.panel5.TabIndex = 8;
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
            this.navPanel.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.panelDesktopPane.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button authBtn;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Label label1;
    }
}