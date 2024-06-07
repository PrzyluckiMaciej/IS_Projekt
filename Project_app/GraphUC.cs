using Insight.Database;
using MySql.Data.MySqlClient;
using Project_app.ORM_classes;
using Project_app.ORM_interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_app
{
    public partial class GraphUC : UserControl
    {
        private string connectionStr;
        private MySqlConnection con;
        private ICountryRepository repo;
        public GraphUC()
        {
            connectionStr = "SERVER=localhost;DATABASE=covid;UID=covidAdmin;PASSWORD=covid;";
            con = new MySqlConnection(connectionStr);
            repo = con.As<ICountryRepository>();
            InitializeComponent();
            generateCasesChart();
        }

        public void generateCasesChart()
        {
            IList<CountrySet> resultsBefore = repo.GetAllCasesBefore();
            IList<CountrySet> resultsAfter = repo.GetAllCasesAfter();
            List<CountrySet> results = new List<CountrySet>();
            results.AddRange(resultsBefore);
            results.AddRange(resultsAfter);

            var objChart = casesChart.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisX.Minimum = 1;
            objChart.AxisX.Maximum = 11;

            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = 0;
            objChart.AxisY.Maximum = 4182966;

            casesChart.Series.Clear();

            casesChart.Series.Add("Zachorowania"); 
            casesChart.Series["Zachorowania"].Color = Color.FromArgb(26, 67, 201);
            casesChart.Series["Zachorowania"].Legend = "ZachorowaniaLegend";
            casesChart.Series["Zachorowania"].ChartArea = "ZachorowaniaChartArea";
            casesChart.Series["Zachorowania"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            
        }
    }
}
