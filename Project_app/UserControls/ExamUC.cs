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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;
using Library.Forms;
using Project_app.UserControls;


namespace Project_app
{
    public partial class ExamUC : UserControl
    {
        private string when;
        private string token;
        RestClient client;
        public ExamUC(string token)
        {
            InitializeComponent();
            this.token = token;
            dataGridView.Visible = false;
            beforeButton.FlatStyle = FlatStyle.Flat;
            afterButton.FlatStyle = FlatStyle.Flat;
            beforeButton.FlatAppearance.BorderSize = 0;
            afterButton.FlatAppearance.BorderSize = 0;
            ChoiceExportExams.SelectedIndex = 0;
            ChoiceImportExams.SelectedIndex = 0;
            client = new RestClient("http://localhost:8080/api");
            client.AddDefaultHeader("Authorization", string.Format("Bearer {0}", token));
        }

        private void beforeButton_Click(object sender, EventArgs e)
        {
            var request = new RestRequest("/exams/get_exams_before", Method.Get);
            request.RequestFormat = DataFormat.None;
            var response = client.Execute(request);
            HttpStatusCode statusCode = response.StatusCode;
            int numericStatusCode = (int)statusCode;
            if (numericStatusCode == 200)
            {
                beforeButton.FlatAppearance.BorderColor = Color.Green;
                afterButton.FlatAppearance.BorderSize = 0;
                beforeButton.FlatAppearance.BorderSize = 1;
                var data = JArray.Parse(response.Content).ToObject<SortableBindingList<ExamResult>>();
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
            var request = new RestRequest("/exams/get_exams_after", Method.Get);
            request.RequestFormat = DataFormat.None;
            var response = client.Execute(request);
            HttpStatusCode statusCode = response.StatusCode;
            int numericStatusCode = (int)statusCode;
            if (numericStatusCode == 200)
            {
                beforeButton.FlatAppearance.BorderSize = 0;
                afterButton.FlatAppearance.BorderSize = 1;
                afterButton.FlatAppearance.BorderColor = Color.Green;
                var data = JArray.Parse(response.Content).ToObject<SortableBindingList<ExamResult>>();
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
            IList<ExamResult> results = dataGridView.DataSource as IList<ExamResult>;
            string selectedFormat = ChoiceExportExams.SelectedItem.ToString().ToUpper();
            DataExporter.ExportData(results, selectedFormat, when, "exams");
        }

        private void import_Click(object sender, EventArgs e)
        {
            string selectedFormat = ChoiceImportExams.SelectedItem.ToString().ToUpper();
            DataImporter.ImportData<ExamResult>(selectedFormat, when, "exams", token);
            if (when == "before") beforeButton.PerformClick();
            if (when == "after") afterButton.PerformClick();
        }

        private void configureDGV(DataGridView dgv)
        {
            DataGridViewElementStates states = DataGridViewElementStates.None;
            dgv.ScrollBars = ScrollBars.Vertical;
            var totalWidth = dgv.Columns.GetColumnsWidth(states) + dgv.RowHeadersWidth;
            dgv.Width = totalWidth;
            dgv.Left = (this.ClientSize.Width - dgv.Width) / 2;
            dgv.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
        }
    }
}
