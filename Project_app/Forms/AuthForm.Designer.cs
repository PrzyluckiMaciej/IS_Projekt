namespace Project_app
{
    partial class AuthForm
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
            logLabel = new Label();
            usernameTextBox = new TextBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            logButton = new Button();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // logLabel
            // 
            logLabel.AutoSize = true;
            logLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            logLabel.Location = new Point(87, 9);
            logLabel.Margin = new Padding(0);
            logLabel.Name = "logLabel";
            logLabel.Size = new Size(110, 25);
            logLabel.TabIndex = 0;
            logLabel.Text = "Logowanie";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(22, 106);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(228, 23);
            usernameTextBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            usernameLabel.Location = new Point(22, 86);
            usernameLabel.Margin = new Padding(0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(228, 17);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Nazwa użytkownika";
            // 
            // passwordLabel
            // 
            passwordLabel.Location = new Point(22, 145);
            passwordLabel.Margin = new Padding(0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(228, 17);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Hasło";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(22, 165);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(228, 23);
            passwordTextBox.TabIndex = 3;
            // 
            // logButton
            // 
            logButton.Location = new Point(87, 242);
            logButton.Name = "logButton";
            logButton.Size = new Size(110, 23);
            logButton.TabIndex = 5;
            logButton.Text = "Zaloguj się";
            logButton.UseVisualStyleBackColor = true;
            logButton.Click += logButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(22, 204);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(228, 35);
            errorLabel.TabIndex = 6;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 277);
            Controls.Add(errorLabel);
            Controls.Add(logButton);
            Controls.Add(passwordLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameLabel);
            Controls.Add(usernameTextBox);
            Controls.Add(logLabel);
            MaximumSize = new Size(290, 316);
            MinimumSize = new Size(290, 316);
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Logowanie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label logLabel;
        private TextBox usernameTextBox;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Button logButton;
        private Label errorLabel;
    }
}