namespace Project_app
{
    partial class GraphUC
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            examLabel = new Label();
            casesDeathsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            examsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)casesDeathsChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)examsChart).BeginInit();
            SuspendLayout();
            // 
            // examLabel
            // 
            examLabel.Dock = DockStyle.Top;
            examLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            examLabel.Location = new Point(0, 0);
            examLabel.Name = "examLabel";
            examLabel.Size = new Size(927, 21);
            examLabel.TabIndex = 4;
            examLabel.Text = "Wykresy";
            examLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // casesDeathsChart
            // 
            chartArea1.Name = "ChartArea1";
            casesDeathsChart.ChartAreas.Add(chartArea1);
            legend1.Alignment = StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            casesDeathsChart.Legends.Add(legend1);
            casesDeathsChart.Location = new Point(3, 24);
            casesDeathsChart.Name = "casesDeathsChart";
            casesDeathsChart.Size = new Size(455, 300);
            casesDeathsChart.TabIndex = 5;
            casesDeathsChart.Text = "chart1";
            // 
            // examsChart
            // 
            chartArea2.Name = "ChartArea1";
            examsChart.ChartAreas.Add(chartArea2);
            legend2.Alignment = StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            examsChart.Legends.Add(legend2);
            examsChart.Location = new Point(469, 24);
            examsChart.Name = "examsChart";
            examsChart.Size = new Size(455, 300);
            examsChart.TabIndex = 7;
            examsChart.Text = "chart2";
            // 
            // GraphUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(examsChart);
            Controls.Add(casesDeathsChart);
            Controls.Add(examLabel);
            Name = "GraphUC";
            Size = new Size(927, 558);
            ((System.ComponentModel.ISupportInitialize)casesDeathsChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)examsChart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label examLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart casesDeathsChart;
        private DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart examsChart;
        private DataGridView dataGridView2;
    }
}
