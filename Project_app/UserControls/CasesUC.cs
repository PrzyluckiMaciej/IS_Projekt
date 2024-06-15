using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Project_app.ORM_interfaces;
using Insight.Database;
using Project_app.ORM_classes;

namespace Project_app
{
    public partial class CasesUC : UserControl
    {
        private string connectionStr;
        private MySqlConnection con;
        private ICountryRepository repo;
        public CasesUC()
        {
            connectionStr = "SERVER=localhost;DATABASE=covid;UID=covidAdmin;PASSWORD=covid;";
            con = new MySqlConnection(connectionStr);
            repo = con.As<ICountryRepository>();
            InitializeComponent();
        }

        private void beforeButton_Click(object sender, EventArgs e)
        {
            IList<CountrySet> results = repo.GetAllCasesBefore();
            dataGridView.DataSource = results;
        }

        private void afterButton_Click(object sender, EventArgs e)
        {
            IList<CountrySet> results = repo.GetAllCasesAfter();
            dataGridView.DataSource = results;
        }
    }
}
