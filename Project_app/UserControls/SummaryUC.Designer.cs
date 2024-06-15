namespace Project_app
{
    partial class SummaryUC
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            summaryLabel = new Label();
            casesDeathsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            examsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            covidGraphLabel = new Label();
            examGraphLabel = new Label();
            maxCasesLabel = new Label();
            maxDeathsLabel = new Label();
            minExamAvgLabel = new Label();
            maxExamAvgLabel = new Label();
            refreshButton = new Button();
            ((System.ComponentModel.ISupportInitialize)casesDeathsChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)examsChart).BeginInit();
            SuspendLayout();
            // 
            // summaryLabel
            // 
            summaryLabel.Dock = DockStyle.Top;
            summaryLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            summaryLabel.Location = new Point(0, 0);
            summaryLabel.Name = "summaryLabel";
            summaryLabel.Size = new Size(927, 21);
            summaryLabel.TabIndex = 4;
            summaryLabel.Text = "Podsumowanie";
            summaryLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // casesDeathsChart
            // 
            chartArea3.Name = "ChartArea1";
            casesDeathsChart.ChartAreas.Add(chartArea3);
            legend3.Alignment = StringAlignment.Center;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Name = "Legend1";
            casesDeathsChart.Legends.Add(legend3);
            casesDeathsChart.Location = new Point(0, 77);
            casesDeathsChart.Name = "casesDeathsChart";
            casesDeathsChart.Size = new Size(455, 300);
            casesDeathsChart.TabIndex = 5;
            casesDeathsChart.Text = "chart1";
            // 
            // examsChart
            // 
            chartArea4.Name = "ChartArea1";
            examsChart.ChartAreas.Add(chartArea4);
            legend4.Alignment = StringAlignment.Center;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.Name = "Legend1";
            examsChart.Legends.Add(legend4);
            examsChart.Location = new Point(472, 77);
            examsChart.Name = "examsChart";
            examsChart.Size = new Size(455, 300);
            examsChart.TabIndex = 7;
            examsChart.Text = "chart2";
            // 
            // covidGraphLabel
            // 
            covidGraphLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            covidGraphLabel.Location = new Point(3, 30);
            covidGraphLabel.Name = "covidGraphLabel";
            covidGraphLabel.Size = new Size(452, 44);
            covidGraphLabel.TabIndex = 8;
            covidGraphLabel.Text = "Wykres śmierci i zachorowań na Covid-19 od stycznia do listopada 2020.";
            covidGraphLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // examGraphLabel
            // 
            examGraphLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            examGraphLabel.Location = new Point(472, 30);
            examGraphLabel.Name = "examGraphLabel";
            examGraphLabel.Size = new Size(452, 44);
            examGraphLabel.TabIndex = 9;
            examGraphLabel.Text = "Wykres średnich wyników egzaminów maturalnych w latach 2015 - 2023.";
            examGraphLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // maxCasesLabel
            // 
            maxCasesLabel.Location = new Point(3, 380);
            maxCasesLabel.Name = "maxCasesLabel";
            maxCasesLabel.Padding = new Padding(10, 0, 0, 0);
            maxCasesLabel.Size = new Size(452, 36);
            maxCasesLabel.TabIndex = 10;
            // 
            // maxDeathsLabel
            // 
            maxDeathsLabel.Location = new Point(3, 416);
            maxDeathsLabel.Name = "maxDeathsLabel";
            maxDeathsLabel.Padding = new Padding(10, 0, 0, 0);
            maxDeathsLabel.Size = new Size(452, 36);
            maxDeathsLabel.TabIndex = 11;
            // 
            // minExamAvgLabel
            // 
            minExamAvgLabel.Location = new Point(472, 380);
            minExamAvgLabel.Name = "minExamAvgLabel";
            minExamAvgLabel.Padding = new Padding(10, 0, 0, 0);
            minExamAvgLabel.Size = new Size(452, 36);
            minExamAvgLabel.TabIndex = 12;
            // 
            // maxExamAvgLabel
            // 
            maxExamAvgLabel.Location = new Point(472, 416);
            maxExamAvgLabel.Name = "maxExamAvgLabel";
            maxExamAvgLabel.Padding = new Padding(10, 0, 0, 0);
            maxExamAvgLabel.Size = new Size(452, 36);
            maxExamAvgLabel.TabIndex = 13;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(830, 4);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(75, 23);
            refreshButton.TabIndex = 14;
            refreshButton.Text = "Odśwież";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // SummaryUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(refreshButton);
            Controls.Add(maxExamAvgLabel);
            Controls.Add(minExamAvgLabel);
            Controls.Add(maxDeathsLabel);
            Controls.Add(maxCasesLabel);
            Controls.Add(examGraphLabel);
            Controls.Add(covidGraphLabel);
            Controls.Add(examsChart);
            Controls.Add(casesDeathsChart);
            Controls.Add(summaryLabel);
            Name = "SummaryUC";
            Size = new Size(927, 558);
            ((System.ComponentModel.ISupportInitialize)casesDeathsChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)examsChart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label summaryLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart casesDeathsChart;
        private DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart examsChart;
        private DataGridView dataGridView2;
        private Label covidGraphLabel;
        private Label examGraphLabel;
        private Label maxCasesLabel;
        private Label maxDeathsLabel;
        private Label minExamAvgLabel;
        private Label maxExamAvgLabel;
        private Button refreshButton;
    }
}
