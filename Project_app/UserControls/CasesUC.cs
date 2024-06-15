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
using System.Xml.Serialization;

using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
using YamlDotNet.Serialization;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Net;

namespace Project_app
{
    public partial class CasesUC : UserControl
    {
        private string connectionStr;
        private MySqlConnection con;
        private ICountryRepository repo;
        private string when;
        private string token;
        public CasesUC(string token)
        {
            connectionStr = "SERVER=localhost;DATABASE=covid;UID=covidAdmin;PASSWORD=covid;";
            con = new MySqlConnection(connectionStr);
            repo = con.As<ICountryRepository>();
            InitializeComponent();
            this.token = token;
        }

        private void beforeButton_Click(object sender, EventArgs e)
        {
            var client = new RestClient("http://localhost:8080/api");
            client.AddDefaultHeader("Authorization", string.Format("Bearer {0}", token));
            var request = new RestRequest("/cases/get_cases_before", Method.Get);
            request.RequestFormat = DataFormat.None;
            var response = client.Execute(request);
            HttpStatusCode statusCode = response.StatusCode;
            int numericStatusCode = (int)statusCode;
            if (numericStatusCode == 200)
            {
                var data = JArray.Parse(response.Content).ToObject<IList<CountrySet>>();
                dataGridView.DataSource = data;
                when = "before";
            }
            else if (numericStatusCode == 403)
            {
                MessageBox.Show("Odmowa dostępu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void afterButton_Click(object sender, EventArgs e)
        {
            var client = new RestClient("http://localhost:8080/api");
            client.AddDefaultHeader("Authorization", string.Format("Bearer {0}", token));
            var request = new RestRequest("/cases/get_cases_after", Method.Get);
            request.RequestFormat = DataFormat.None;
            var response = client.Execute(request);
            HttpStatusCode statusCode = response.StatusCode;
            int numericStatusCode = (int)statusCode;
            if (numericStatusCode == 200)
            {
                var data = JArray.Parse(response.Content).ToObject<IList<CountrySet>>();
                dataGridView.DataSource = data;
                when = "after";
            }
            else if (numericStatusCode == 403)
            {
                MessageBox.Show("Odmowa dostępu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            IList<CountrySet> results = dataGridView.DataSource as IList<CountrySet>;
            string selectedFormat = ChoiceExportCases.SelectedItem.ToString().ToUpper();
            DataExporter.ExportData(results, selectedFormat, when, "cases");
        }

        private void import_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Import do zrobienia.", "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
