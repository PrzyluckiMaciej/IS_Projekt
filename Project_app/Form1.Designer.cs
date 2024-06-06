namespace Project_app
{
    partial class Form1
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
            graphButton = new Button();
            contentPanel = new Panel();
            mainViewUC = new MainView();
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
            panel4.Controls.Add(graphButton);
            panel4.Location = new Point(3, 238);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 42);
            panel4.TabIndex = 5;
            // 
            // graphButton
            // 
            graphButton.FlatStyle = FlatStyle.Flat;
            graphButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            graphButton.ForeColor = SystemColors.Control;
            graphButton.Location = new Point(-3, -8);
            graphButton.Name = "graphButton";
            graphButton.Padding = new Padding(5, 0, 0, 0);
            graphButton.Size = new Size(257, 55);
            graphButton.TabIndex = 2;
            graphButton.Text = "Wykresy";
            graphButton.TextAlign = ContentAlignment.MiddleLeft;
            graphButton.UseVisualStyleBackColor = true;
            graphButton.Click += graphButton_Click;
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(mainViewUC);
            contentPanel.Location = new Point(207, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(908, 558);
            contentPanel.TabIndex = 2;
            // 
            // mainViewUC
            // 
            mainViewUC.Location = new Point(3, 0);
            mainViewUC.Margin = new Padding(3, 4, 3, 4);
            mainViewUC.Name = "mainViewUC";
            mainViewUC.Size = new Size(906, 558);
            mainViewUC.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1114, 558);
            Controls.Add(contentPanel);
            Controls.Add(menu);
            MaximumSize = new Size(1130, 597);
            MinimumSize = new Size(1130, 597);
            Name = "Form1";
            Text = "Covid";
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
        private Panel contentPanel;
        private MainView mainViewUC;
        private Button casesButton;
        private Panel panel4;
        private Button graphButton;
    }
}
