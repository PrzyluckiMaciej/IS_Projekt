using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Org.BouncyCastle.Crmf;
using Project_app.Authentication;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_app
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            logLabel.Left = (this.ClientSize.Width - logLabel.Width) / 2;
            usernameTextBox.Left = (this.ClientSize.Width - usernameTextBox.Width) / 2;
            usernameLabel.Left = (this.ClientSize.Width - usernameLabel.Width) / 2;
            passwordTextBox.Left = (this.ClientSize.Width - passwordTextBox.Width) / 2;
            passwordLabel.Left = (this.ClientSize.Width - passwordLabel.Width) / 2;
            logButton.Left = (this.ClientSize.Width - logButton.Width) / 2;
            passwordTextBox.PasswordChar = '*';
            this.usernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
            this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) logButton_Click(null, EventArgs.Empty);
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            if(username != "" && password != "")
            {
                var client = new RestClient("http://localhost:8080/api");
                var request = new RestRequest("/users/authenticate", Method.Post);
                request.RequestFormat = DataFormat.Json;
                User user = new User(username, password);
                request.AddBody(user);
                var response = client.Execute(request);
                HttpStatusCode statusCode = response.StatusCode;
                int numericStatusCode = (int)statusCode;
                if (numericStatusCode == 200)
                {
                    this.Hide();
                    MainForm main = new MainForm(user);
                    main.ShowDialog();
                    this.Close();
                }
                else if (numericStatusCode == 400)
                {
                    dynamic data = JObject.Parse(response.Content);
                    errorLabel.Text = data.message;
                }
            }
            else
            {
                errorLabel.Text = "Uzupełnij pola.";
            }
        }
    }
}
