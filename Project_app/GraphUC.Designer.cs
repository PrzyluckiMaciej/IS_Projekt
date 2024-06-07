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
            examLabel = new Label();
            lineChart1 = new MindFusion.Charting.WinForms.LineChart();
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
            // lineChart1
            // 
            lineChart1.LegendTitle = "Legend";
            lineChart1.Location = new Point(32, 47);
            lineChart1.Name = "lineChart1";
            lineChart1.Padding = new Padding(5);
            lineChart1.ShowLegend = true;
            lineChart1.Size = new Size(384, 256);
            lineChart1.SubtitleFontName = null;
            lineChart1.SubtitleFontSize = null;
            lineChart1.SubtitleFontStyle = null;
            lineChart1.TabIndex = 5;
            lineChart1.Text = "lineChart1";
            lineChart1.Theme.UniformSeriesFill = new MindFusion.Drawing.SolidBrush("#FF90EE90");
            lineChart1.Theme.UniformSeriesStroke = new MindFusion.Drawing.SolidBrush("#FF000000");
            lineChart1.Theme.UniformSeriesStrokeThickness = 2D;
            lineChart1.TitleFontName = null;
            lineChart1.TitleFontSize = null;
            lineChart1.TitleFontStyle = null;
            // 
            // GraphUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lineChart1);
            Controls.Add(examLabel);
            Name = "GraphUC";
            Size = new Size(927, 558);
            ResumeLayout(false);
        }

        #endregion

        private Label examLabel;
        private MindFusion.Charting.WinForms.LineChart lineChart1;
    }
}
