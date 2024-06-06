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

namespace Project_app
{
    public partial class CasesUC : UserControl
    {
        private ManagerDB ManagerDB;
        public CasesUC()
        {
            ManagerDB = new ManagerDB();
            InitializeComponent();
        }

        private void beforeButton_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = ManagerDB.getData("weekly_cases_before");
        }

        private void afterButton_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = ManagerDB.getData("weekly_cases_after");
        }
    }
}
