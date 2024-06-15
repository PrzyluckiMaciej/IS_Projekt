using Insight.Database;
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
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crmf;
using Newtonsoft.Json;
using System.Xml.Serialization;

using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
using YamlDotNet.Serialization;

namespace Project_app
{
    public partial class DeathsUC : UserControl
    {
        private string connectionStr;
        private MySqlConnection con;
        private ICountryRepository repo;
        private string when;
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
            when = "before";
        }

        private void afterButton_Click(object sender, EventArgs e)
        {
            IList<CountrySet> results = repo.GetAllDeathsAfter();
            dataGridView.DataSource = results;
            when = "after";
        }

        private void export_Click(object sender, EventArgs e)
        {
            IList<CountrySet> results = dataGridView.DataSource as IList<CountrySet>;
            string selectedFormat = ChoiceExportDeaths.SelectedItem.ToString().ToUpper();
            DataExporter.ExportData(results, selectedFormat, when, "deaths");
        }

        private void import_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Import do zrobienia.", "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
