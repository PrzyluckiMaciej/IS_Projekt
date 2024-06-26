﻿namespace Project_app
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menu = new FlowLayoutPanel();
            panel1 = new Panel();
            mainPageLabel = new Label();
            panel2 = new Panel();
            casesButton = new Button();
            panel3 = new Panel();
            deathsButton = new Button();
            panel5 = new Panel();
            examButton = new Button();
            panel4 = new Panel();
            summaryButton = new Button();
            ucPanel = new Panel();
            contentPanel = new Panel();
            logoutButton = new Button();
            menu.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            contentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = Color.FromArgb(33, 33, 33);
            menu.Controls.Add(panel1);
            menu.Controls.Add(panel2);
            menu.Controls.Add(panel3);
            menu.Controls.Add(panel5);
            menu.Controls.Add(panel4);
            menu.Controls.Add(logoutButton);
            menu.Dock = DockStyle.Left;
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(202, 558);
            menu.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(mainPageLabel);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 85);
            panel1.TabIndex = 0;
            // 
            // mainPageLabel
            // 
            mainPageLabel.AutoSize = true;
            mainPageLabel.Cursor = Cursors.Hand;
            mainPageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            mainPageLabel.ForeColor = SystemColors.Control;
            mainPageLabel.Location = new Point(9, 32);
            mainPageLabel.Name = "mainPageLabel";
            mainPageLabel.Size = new Size(121, 21);
            mainPageLabel.TabIndex = 1;
            mainPageLabel.Text = "Strona główna";
            mainPageLabel.Click += mainPageLabel_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(casesButton);
            panel2.Location = new Point(3, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(239, 42);
            panel2.TabIndex = 1;
            // 
            // casesButton
            // 
            casesButton.FlatStyle = FlatStyle.Flat;
            casesButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            casesButton.ForeColor = SystemColors.Control;
            casesButton.Location = new Point(-3, -5);
            casesButton.Name = "casesButton";
            casesButton.Padding = new Padding(5, 0, 0, 0);
            casesButton.Size = new Size(254, 55);
            casesButton.TabIndex = 5;
            casesButton.Text = "Zachorowania";
            casesButton.TextAlign = ContentAlignment.MiddleLeft;
            casesButton.UseVisualStyleBackColor = true;
            casesButton.Click += casesButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(deathsButton);
            panel3.Location = new Point(3, 142);
            panel3.Name = "panel3";
            panel3.Size = new Size(239, 42);
            panel3.TabIndex = 2;
            // 
            // deathsButton
            // 
            deathsButton.FlatStyle = FlatStyle.Flat;
            deathsButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            deathsButton.ForeColor = SystemColors.Control;
            deathsButton.Location = new Point(-3, -6);
            deathsButton.Name = "deathsButton";
            deathsButton.Padding = new Padding(5, 0, 0, 0);
            deathsButton.Size = new Size(254, 55);
            deathsButton.TabIndex = 1;
            deathsButton.Text = "Śmierci";
            deathsButton.TextAlign = ContentAlignment.MiddleLeft;
            deathsButton.UseVisualStyleBackColor = true;
            deathsButton.Click += deathsButton_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(examButton);
            panel5.Location = new Point(3, 190);
            panel5.Name = "panel5";
            panel5.Size = new Size(239, 42);
            panel5.TabIndex = 4;
            // 
            // examButton
            // 
            examButton.FlatStyle = FlatStyle.Flat;
            examButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            examButton.ForeColor = SystemColors.Control;
            examButton.Location = new Point(-3, -6);
            examButton.Name = "examButton";
            examButton.Padding = new Padding(5, 0, 0, 0);
            examButton.Size = new Size(254, 55);
            examButton.TabIndex = 1;
            examButton.Text = "Wyniki matur";
            examButton.TextAlign = ContentAlignment.MiddleLeft;
            examButton.UseVisualStyleBackColor = true;
            examButton.Click += examButton_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(summaryButton);
            panel4.Location = new Point(3, 238);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 42);
            panel4.TabIndex = 5;
            // 
            // summaryButton
            // 
            summaryButton.FlatStyle = FlatStyle.Flat;
            summaryButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            summaryButton.ForeColor = SystemColors.Control;
            summaryButton.Location = new Point(-3, -8);
            summaryButton.Name = "summaryButton";
            summaryButton.Padding = new Padding(5, 0, 0, 0);
            summaryButton.Size = new Size(257, 55);
            summaryButton.TabIndex = 2;
            summaryButton.Text = "Podsumowanie";
            summaryButton.TextAlign = ContentAlignment.MiddleLeft;
            summaryButton.UseVisualStyleBackColor = true;
            summaryButton.Click += summaryButton_Click;
            // 
            // ucPanel
            // 
            ucPanel.BackColor = SystemColors.Control;
            ucPanel.Location = new Point(0, 0);
            ucPanel.Name = "ucPanel";
            ucPanel.Size = new Size(912, 558);
            ucPanel.TabIndex = 0;
            // 
            // contentPanel
            // 
            contentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contentPanel.BackColor = Color.FromArgb(255, 128, 128);
            contentPanel.Controls.Add(ucPanel);
            contentPanel.Location = new Point(202, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(912, 558);
            contentPanel.TabIndex = 2;
            // 
            // logoutButton
            // 
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            logoutButton.ForeColor = SystemColors.Control;
            logoutButton.Location = new Point(3, 286);
            logoutButton.Name = "logoutButton";
            logoutButton.Padding = new Padding(5, 0, 0, 0);
            logoutButton.Size = new Size(257, 55);
            logoutButton.TabIndex = 6;
            logoutButton.Text = "Wyloguj się";
            logoutButton.TextAlign = ContentAlignment.MiddleLeft;
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1114, 558);
            Controls.Add(contentPanel);
            Controls.Add(menu);
            MaximumSize = new Size(1130, 597);
            MinimumSize = new Size(1130, 597);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Klient";
            menu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel menu;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button deathsButton;
        private Panel panel5;
        private Button examButton;
        private Label mainPageLabel;
        private Button casesButton;
        private Panel panel4;
        private Button summaryButton;
        private Panel ucPanel;
        private Panel contentPanel;
        private Button logoutButton;
    }
}
