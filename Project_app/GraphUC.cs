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
        private ICountryRepository countryRepo;
        private IExamRepository examRepo;
        public GraphUC()
        {
            connectionStr = "SERVER=localhost;DATABASE=covid;UID=covidAdmin;PASSWORD=covid;";
            con = new MySqlConnection(connectionStr);
            countryRepo = con.As<ICountryRepository>();
            examRepo = con.As<IExamRepository>();
            InitializeComponent();
            generateCasesChart();
        }

        public void generateCasesChart()
        {
            IList<AverageCountryData> casesBefore = countryRepo.GetAverageCasesBefore();
            IList<AverageCountryData> casesAfter = countryRepo.GetAverageCasesAfter();
            List<AverageCountryData> cases = new List<AverageCountryData>();
            cases.AddRange(casesBefore);
            cases.AddRange(casesAfter);

            IList<AverageCountryData> deathsBefore = countryRepo.GetAverageDeathsBefore();
            IList<AverageCountryData> deathsAfter = countryRepo.GetAverageDeathsAfter();
            List<AverageCountryData> deaths = new List<AverageCountryData>();
            deaths.AddRange(deathsBefore);
            deaths.AddRange(deathsAfter);

            var objChart = casesDeathsChart.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisX.Minimum = 1;
            objChart.AxisX.Maximum = 11;

            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = 0;
            objChart.AxisY.Maximum = 4000000;

            casesDeathsChart.Series.Clear();

            casesDeathsChart.Series.Add("Zachorowania");
            casesDeathsChart.Series["Zachorowania"].Color = Color.FromArgb(26, 67, 201);
            casesDeathsChart.Series["Zachorowania"].Legend = "Legend1";
            casesDeathsChart.Series["Zachorowania"].ChartArea = "ChartArea1";
            casesDeathsChart.Series["Zachorowania"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            foreach(AverageCountryData i in cases)
            {
                casesDeathsChart.Series["Zachorowania"].Points.AddXY(i.month, i.average);
            }

            casesDeathsChart.Series.Add("Śmierci");
            casesDeathsChart.Series["Śmierci"].Color = Color.FromArgb(235, 64, 52);
            casesDeathsChart.Series["Śmierci"].Legend = "Legend1";
            casesDeathsChart.Series["Śmierci"].ChartArea = "ChartArea1";
            casesDeathsChart.Series["Śmierci"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            foreach (AverageCountryData i in deaths)
            {
                casesDeathsChart.Series["Śmierci"].Points.AddXY(i.month, i.average);
            }
        }

        public void generateExamChart()
        {
            IList<AverageExamData> examsBefore = examRepo.GetAverageExamPerYearBefore();
            IList<AverageExamData> examsAfter = examRepo.GetAverageExamPerYearAfter();
            List<AverageExamData> exams = new List<AverageExamData>();
            exams.AddRange(examsBefore);
            exams.AddRange(examsAfter);

            var objChart = examsChart.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisX.Minimum = 0;

            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
        }
    }
}
