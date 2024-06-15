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
using Project_app.Data_management;


namespace Project_app
{
    public partial class ExamUC : UserControl
    {
        private string connectionStr;
        private MySqlConnection con;
        private IExamRepository repo;
        private string when;
        private string token;
        public ExamUC(string token)
        {
            connectionStr = "SERVER=localhost;DATABASE=covid;UID=covidAdmin;PASSWORD=covid;";
            con = new MySqlConnection(connectionStr);
            repo = con.As<IExamRepository>();
            InitializeComponent();
            this.token = token;
        }

        private void beforeButton_Click(object sender, EventArgs e)
        {
            var client = new RestClient("http://localhost:8080/api");
            client.AddDefaultHeader("Authorization", string.Format("Bearer {0}", token));
            var request = new RestRequest("/exams/get_exams_before", Method.Get);
            request.RequestFormat = DataFormat.None;
            var response = client.Execute(request);
            HttpStatusCode statusCode = response.StatusCode;
            int numericStatusCode = (int)statusCode;
            if (numericStatusCode == 200)
            {
                var data = JArray.Parse(response.Content).ToObject<IList<ExamResult>>();
                dataGridView.DataSource = data;
                when = "before";
                sizeDGV(dataGridView);
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
            var request = new RestRequest("/exams/get_exams_after", Method.Get);
            request.RequestFormat = DataFormat.None;
            var response = client.Execute(request);
            HttpStatusCode statusCode = response.StatusCode;
            int numericStatusCode = (int)statusCode;
            if (numericStatusCode == 200)
            {
                var data = JArray.Parse(response.Content).ToObject<IList<ExamResult>>();
                dataGridView.DataSource = data;
                when = "after";
                sizeDGV(dataGridView);
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
            MessageBox.Show("Import do zrobienia.", "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sizeDGV(DataGridView dgv)
        {
            DataGridViewElementStates states = DataGridViewElementStates.None;
            dgv.ScrollBars = ScrollBars.Vertical;
            var totalWidth = dgv.Columns.GetColumnsWidth(states) + dgv.RowHeadersWidth;
            dgv.Width = totalWidth;
            dgv.Left = (this.ClientSize.Width - dgv.Width) / 2;
        }
    }
}
