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

namespace Project_app
{
    public partial class ExamUC : UserControl
    {
        private string connectionStr;
        private MySqlConnection con;
        private IExamRepository repo;
        public ExamUC()
        {
            connectionStr = "SERVER=localhost;DATABASE=covid;UID=covidAdmin;PASSWORD=covid;";
            con = new MySqlConnection(connectionStr);
            repo = con.As<IExamRepository>();
            InitializeComponent();
        }

        private void beforeButton_Click(object sender, EventArgs e)
        {
            IList<ExamResult> results = repo.GetAllExamResultsBefore();
            dataGridView.DataSource = results;
            sizeDGV(dataGridView);
        }

        private void afterButton_Click(object sender, EventArgs e)
        {
            IList<ExamResult> results = repo.GetAllExamResultsAfter();
            dataGridView.DataSource = results;
            sizeDGV(dataGridView);
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
