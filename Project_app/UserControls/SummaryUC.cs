using Insight.Database;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using Project_app.ORM_classes;
using Project_app.ORM_interfaces;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using YamlDotNet.Core.Tokens;

namespace Project_app
{
    public partial class SummaryUC : UserControl
    {
        private string connectionStr;
        private MySqlConnection con;
        private ICountryRepository countryRepo;
        private IExamRepository examRepo;
        private string token;
        public SummaryUC(string token)
        {
            connectionStr = "SERVER=localhost;DATABASE=covid;UID=covidAdmin;PASSWORD=covid;";
            con = new MySqlConnection(connectionStr);
            countryRepo = con.As<ICountryRepository>();
            examRepo = con.As<IExamRepository>();
            InitializeComponent();
            this.token = token;
            generateCasesChart();
            generateExamChart();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            casesDeathsChart.Annotations.Clear();
            examsChart.Annotations.Clear();
            generateCasesChart();
            generateExamChart();
        }

        public void generateCasesChart()
        {
            IList<AverageCountryData> casesBefore = [];
            IList<AverageCountryData> casesAfter = [];
            var client = new RestClient("http://localhost:8080/api");
            client.AddDefaultHeader("Authorization", string.Format("Bearer {0}", token));
            var request = new RestRequest("/cases/get_average_cases_before", Method.Get);
            request.RequestFormat = DataFormat.None;
            var response = client.Execute(request);
            HttpStatusCode statusCode = response.StatusCode;
            int numericStatusCode = (int)statusCode;
            if (numericStatusCode == 200)
            {
                casesBefore = JArray.Parse(response.Content).ToObject<IList<AverageCountryData>>();
            }
            request = new RestRequest("/cases/get_average_cases_after", Method.Get);
            request.RequestFormat = DataFormat.None;
            response = client.Execute(request);
            statusCode = response.StatusCode;
            numericStatusCode = (int)statusCode;
            if (numericStatusCode == 200)
            {
                casesAfter = JArray.Parse(response.Content).ToObject<IList<AverageCountryData>>();
            }

            List<AverageCountryData> cases = new List<AverageCountryData>();
            cases.AddRange(casesBefore);
            cases.AddRange(casesAfter);

            maxCasesLabel.Text = "Największa liczba zachorowań: "+calculateCasesDeaths(cases).ToString();

            IList<AverageCountryData> deathsBefore = [];
            IList<AverageCountryData> deathsAfter = [];
            request = new RestRequest("/deaths/get_average_deaths_before", Method.Get);
            request.RequestFormat = DataFormat.None;
            response = client.Execute(request);
            statusCode = response.StatusCode;
            numericStatusCode = (int)statusCode;
            if (numericStatusCode == 200)
            {
                deathsBefore = JArray.Parse(response.Content).ToObject<IList<AverageCountryData>>();
            }
            request = new RestRequest("/deaths/get_average_deaths_after", Method.Get);
            request.RequestFormat = DataFormat.None;
            response = client.Execute(request);
            statusCode = response.StatusCode;
            numericStatusCode = (int)statusCode;
            if (numericStatusCode == 200)
            {
                deathsAfter = JArray.Parse(response.Content).ToObject<IList<AverageCountryData>>();
            }

            List<AverageCountryData> deaths = new List<AverageCountryData>();
            deaths.AddRange(deathsBefore);
            deaths.AddRange(deathsAfter);

            maxDeathsLabel.Text = "Największa liczba śmierci:"+calculateCasesDeaths(deaths).ToString();

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
            casesDeathsChart.ChartAreas[0].AxisX.Title = "Miesiące";
            casesDeathsChart.ChartAreas[0].AxisY.Title = "Liczba zachorowań/śmierci";
            createVerticalLine(casesDeathsChart, 3);
            stylizeChart(casesDeathsChart);
        }

        public void generateExamChart()
        {
            IList<AverageExamData> examsBefore = [];
            IList<AverageExamData> examsAfter = [];
            var client = new RestClient("http://localhost:8080/api");
            client.AddDefaultHeader("Authorization", string.Format("Bearer {0}", token));
            var request = new RestRequest("/exams/get_average_exams_before", Method.Get);
            request.RequestFormat = DataFormat.None;
            var response = client.Execute(request);
            HttpStatusCode statusCode = response.StatusCode;
            int numericStatusCode = (int)statusCode;
            if (numericStatusCode == 200)
            {
                examsBefore = JArray.Parse(response.Content).ToObject<IList<AverageExamData>>();
            }
            request = new RestRequest("/exams/get_average_exams_after", Method.Get);
            request.RequestFormat = DataFormat.None;
            response = client.Execute(request);
            statusCode = response.StatusCode;
            numericStatusCode = (int)statusCode;
            if (numericStatusCode == 200)
            {
                examsAfter = JArray.Parse(response.Content).ToObject<IList<AverageExamData>>();
            }
            List<AverageExamData> exams = new List<AverageExamData>();
            exams.AddRange(examsBefore);
            exams.AddRange(examsAfter);

            double min = calculateMinExams(exams);
            double max = calculateMaxExams(exams);
            maxExamAvgLabel.Text = "Najwyższa średnia: "+max.ToString();
            minExamAvgLabel.Text = "Najniższa średnia: "+min.ToString();

            var objChart = examsChart.ChartAreas[0];
            objChart.AxisX.IntervalType = DateTimeIntervalType.Number;
            objChart.AxisX.Minimum = 2015;
            objChart.AxisX.Maximum = 2023;

            objChart.AxisY.IntervalType = DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = 5*(int)Math.Round(min/5.0)-5;
            objChart.AxisY.Maximum = 5 * (int)Math.Round(max / 5.0) + 5;

            examsChart.Series.Clear();

            examsChart.Series.Add("Średnia");
            examsChart.Series["Średnia"].Color = Color.FromArgb(31, 128, 35);
            examsChart.Series["Średnia"].Legend = "Legend1";
            examsChart.Series["Średnia"].ChartArea = "ChartArea1";
            examsChart.Series["Średnia"].ChartType = SeriesChartType.Line;
            foreach (AverageExamData i in exams)
            {
                examsChart.Series["Średnia"].Points.AddXY(i.rok, i.srednia);
            }
            examsChart.ChartAreas[0].AxisX.Title = "Rok";
            examsChart.ChartAreas[0].AxisY.Title = "Średnia wyników z egzaminów";
            createVerticalLine(examsChart, 2020);
            stylizeChart(examsChart);
        }

        public void stylizeChart(Chart chart)
        {
            chart.BackColor = Color.FromArgb(240, 240, 240);
            chart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            chart.ChartAreas[0].AxisX.MinorGrid.LineDashStyle = ChartDashStyle.Dot;
            chart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            chart.ChartAreas[0].AxisY.MinorGrid.LineDashStyle = ChartDashStyle.Dot;
        }

        public void createVerticalLine(Chart chart, double x)
        {
            var line = new VerticalLineAnnotation();
            line.AxisX = chart.ChartAreas[0].AxisX;
            line.IsInfinitive = true;
            line.ClipToChartArea = chart.ChartAreas[0].Name;
            line.Name = "Początek pandemii";
            line.LineColor = Color.Black; 
            line.LineWidth = 2;
            line.X = x;
            chart.Annotations.Add(line);
        }

        public double calculateCasesDeaths(List<AverageCountryData> list) 
        {
            return list.Max(i => i.average);
        }

        public double calculateMaxExams(List<AverageExamData> list)
        {
            return list.Max(i => i.srednia);
        }

        public double calculateMinExams(List<AverageExamData> list)
        {
            return list.Min(i => i.srednia);
        }
    }
}
