using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_app.Authentication;

namespace Project_app
{
    public partial class MainView : UserControl
    {
        User user;
        public MainView(User user)
        {
            InitializeComponent();
            columnButton.Visible = false;
            this.user = user;
            welcomeLabel.Text = "Witaj, " + user.username;
        }

        //użyte do pobrania nazw kolumn z bazy danych w celu utworzenia klasy do implementacji ORM
        private void columnButton_Click(object sender, EventArgs e)
        {
            string connectionStr = "SERVER=localhost;DATABASE=covid;UID=covidClient;PASSWORD=covid;";
            List<string> columns = new List<string>();
            using (MySqlConnection connection = new MySqlConnection(connectionStr))
            {
                string[] restrictions = new string[4] { null, null, "weekly_deaths_before", null };
                connection.Open();
                var columnList = connection.GetSchema("Columns", restrictions).AsEnumerable().Select(s => s.Field<String>("Column_Name")).ToList();
                connection.Close();
                File.WriteAllLines("columnNames.txt", columnList);
                string[] readText = File.ReadAllLines("columnNames.txt");
                for (int i = 0; i < readText.Length; i++)
                {
                    string temp = "public int " + readText[i].Replace(" ", "_") + " { get; set; }";
                    temp = temp.Replace("(", "_");
                    temp = temp.Replace(")", "_");
                    temp = temp.Replace("-", "_");
                    temp = temp.Replace("'", "_");
                    readText[i] = temp;
                }
                File.WriteAllLines("columnNames.txt", readText);
            }
        }
    }
}
