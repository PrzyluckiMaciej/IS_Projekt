using Insight.Database;
using MySql.Data.MySqlClient;
using Project_app.ORM_classes;
using Project_app.ORM_interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_app
{
    public partial class DeathsUC : UserControl
    {
        private string connectionStr;
        private MySqlConnection con;
        private ICountryRepository repo;
        public DeathsUC()
        {
            connectionStr = "SERVER=localhost;DATABASE=covid;UID=covidAdmin;PASSWORD=covid;";
            con = new MySqlConnection(connectionStr);
            repo = con.As<ICountryRepository>();
            InitializeComponent();
        }

        private void beforeButton_Click(object sender, EventArgs e)
        {
            IList<CountrySet> results = repo.GetAllDeathsBefore();
            dataGridView.DataSource = results;
        }

        private void afterButton_Click(object sender, EventArgs e)
        {
            IList<CountrySet> results = repo.GetAllDeathsAfter();
            dataGridView.DataSource = results;
        }
    }
}
