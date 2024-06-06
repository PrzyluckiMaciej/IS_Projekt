using Insight.Database;
using MySql.Data.MySqlClient;
using Project_app.ORM_interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_app
{
    internal class ManagerDB
    {
        private string connectionStr;
        private MySqlConnection con;
        public ManagerDB() {
            connectionStr = "SERVER=localhost;DATABASE=covid;UID=covidAdmin;PASSWORD=covid;";
            con = new MySqlConnection(connectionStr);
        }

        public DataTable getData(string dbTable)
        {
            con.Open();
            string query = "SELECT * FROM " + dbTable;
            MySqlCommand cmd = new MySqlCommand(query, con);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            con.Close();
            return table;

        }
    }
}
