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
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Net;
using Library.Forms;
using Project_app.UserControls;

namespace Project_app
{
    public partial class DeathsUC : UserControl
    {
        private string when;
        private string token;
        RestClient client;
        public DeathsUC(string token)
        {
            InitializeComponent();
            this.token = token;
            dataGridView.Visible = false;
            beforeButton.FlatStyle = FlatStyle.Flat;
            afterButton.FlatStyle = FlatStyle.Flat;
            beforeButton.FlatAppearance.BorderSize = 0;
            afterButton.FlatAppearance.BorderSize = 0;
            client = new RestClient("http://localhost:8080/api");
            client.AddDefaultHeader("Authorization", string.Format("Bearer {0}", token));
            ChoiceExportDeaths.SelectedIndex = 0;
            ChoiceImportDeaths.SelectedIndex = 0;
        }

        private void beforeButton_Click(object sender, EventArgs e)
        {
            var request = new RestRequest("/deaths/get_deaths_before", Method.Get);
            request.RequestFormat = DataFormat.None;
            var response = client.Execute(request);
            HttpStatusCode statusCode = response.StatusCode;
            int numericStatusCode = (int)statusCode;
            if (numericStatusCode == 200)
            {
                beforeButton.FlatAppearance.BorderColor = Color.Green;
                afterButton.FlatAppearance.BorderSize = 0;
                beforeButton.FlatAppearance.BorderSize = 1;
                var data = JArray.Parse(response.Content).ToObject<SortableBindingList<CountrySet>>();
                dataGridView.DataSource = data;
                dataGridView.Visible = true;
                when = "before";
                configureDGV(dataGridView);
            }
            else if (numericStatusCode == 403)
            {
                MessageBox.Show("Odmowa dostępu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void afterButton_Click(object sender, EventArgs e)
        {
            var request = new RestRequest("/deaths/get_deaths_after", Method.Get);
            request.RequestFormat = DataFormat.None;
            var response = client.Execute(request);
            HttpStatusCode statusCode = response.StatusCode;
            int numericStatusCode = (int)statusCode;
            if (numericStatusCode == 200)
            {
                beforeButton.FlatAppearance.BorderSize = 0;
                afterButton.FlatAppearance.BorderSize = 1;
                afterButton.FlatAppearance.BorderColor = Color.Green;
                var data = JArray.Parse(response.Content).ToObject<SortableBindingList<CountrySet>>();
                dataGridView.DataSource = data;
                dataGridView.Visible = true;
                when = "after";
                configureDGV(dataGridView);
            }
            else if (numericStatusCode == 403)
            {
                MessageBox.Show("Odmowa dostępu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            IList<CountrySet> results = dataGridView.DataSource as IList<CountrySet>;
            string selectedFormat = ChoiceExportDeaths.SelectedItem.ToString().ToUpper();
            DataExporter.ExportData(results, selectedFormat, when, "deaths");
        }

        private void import_Click(object sender, EventArgs e)
        {
            string selectedFormat = ChoiceImportDeaths.SelectedItem.ToString().ToUpper();
            DataImporter.ImportData<CountrySet>(selectedFormat, when, "deaths", token);
            if (when == "before") beforeButton.PerformClick();
            if (when == "after") afterButton.PerformClick();
        }

        private void configureDGV(DataGridView dgv)
        {
            dgv.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
        }
    }
}
