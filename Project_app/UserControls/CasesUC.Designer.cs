
namespace Project_app
{
    partial class CasesUC
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
            casesLabel = new Label();
            dataGridView = new DataGridView();
            beforeButton = new Button();
            afterButton = new Button();
            panel1 = new Panel();
            ChoiceExportCases = new ComboBox();
            ChoiceImportCases = new ComboBox();
            ImportCases = new Button();
            ExportCases = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // casesLabel
            // 
            casesLabel.Dock = DockStyle.Top;
            casesLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            casesLabel.Location = new Point(0, 0);
            casesLabel.Name = "casesLabel";
            casesLabel.Size = new Size(912, 21);
            casesLabel.TabIndex = 0;
            casesLabel.Text = "Zachorowania na COVID-19 w 2020 roku";
            casesLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(3, 53);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(906, 502);
            dataGridView.TabIndex = 2;
            // 
            // beforeButton
            // 
            beforeButton.Dock = DockStyle.Right;
            beforeButton.Location = new Point(304, 0);
            beforeButton.Name = "beforeButton";
            beforeButton.Size = new Size(142, 25);
            beforeButton.TabIndex = 3;
            beforeButton.Text = "Dane przed 03.2020";
            beforeButton.UseVisualStyleBackColor = true;
            beforeButton.Click += beforeButton_Click;
            // 
            // afterButton
            // 
            afterButton.Dock = DockStyle.Right;
            afterButton.Location = new Point(446, 0);
            afterButton.Name = "afterButton";
            afterButton.Size = new Size(142, 25);
            afterButton.TabIndex = 4;
            afterButton.Text = "Dane po 03.2020";
            afterButton.UseVisualStyleBackColor = true;
            afterButton.Click += afterButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(ChoiceExportCases);
            panel1.Controls.Add(ChoiceImportCases);
            panel1.Controls.Add(ImportCases);
            panel1.Controls.Add(ExportCases);
            panel1.Controls.Add(beforeButton);
            panel1.Controls.Add(afterButton);
            panel1.Location = new Point(3, 24);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 318, 0);
            panel1.Size = new Size(906, 25);
            panel1.TabIndex = 5;
            // 
            // ChoiceExportCases
            // 
            ChoiceExportCases.DropDownStyle = ComboBoxStyle.DropDownList;
            ChoiceExportCases.FormattingEnabled = true;
            ChoiceExportCases.Items.AddRange(new object[] { "JSON", "XML", "YAML" });
            ChoiceExportCases.Location = new Point(773, 1);
            ChoiceExportCases.Margin = new Padding(3, 2, 3, 2);
            ChoiceExportCases.Name = "ChoiceExportCases";
            ChoiceExportCases.Size = new Size(133, 23);
            ChoiceExportCases.TabIndex = 8;
            // 
            // ChoiceImportCases
            // 
            ChoiceImportCases.DropDownStyle = ComboBoxStyle.DropDownList;
            ChoiceImportCases.FormattingEnabled = true;
            ChoiceImportCases.Items.AddRange(new object[] { "JSON", "XML", "YAML" });
            ChoiceImportCases.Location = new Point(88, 1);
            ChoiceImportCases.Margin = new Padding(3, 2, 3, 2);
            ChoiceImportCases.Name = "ChoiceImportCases";
            ChoiceImportCases.Size = new Size(133, 23);
            ChoiceImportCases.TabIndex = 7;
            // 
            // ImportCases
            // 
            ImportCases.Location = new Point(0, 0);
            ImportCases.Margin = new Padding(3, 2, 3, 2);
            ImportCases.Name = "ImportCases";
            ImportCases.Size = new Size(82, 25);
            ImportCases.TabIndex = 6;
            ImportCases.Text = "IMPORT";
            ImportCases.UseVisualStyleBackColor = true;
            ImportCases.Click += import_Click;
            // 
            // ExportCases
            // 
            ExportCases.Location = new Point(685, 0);
            ExportCases.Margin = new Padding(3, 2, 3, 2);
            ExportCases.Name = "ExportCases";
            ExportCases.Size = new Size(82, 25);
            ExportCases.TabIndex = 5;
            ExportCases.Text = "EXPORT";
            ExportCases.UseVisualStyleBackColor = true;
            ExportCases.Click += export_Click;
            // 
            // CasesUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(dataGridView);
            Controls.Add(casesLabel);
            Name = "CasesUC";
            Size = new Size(912, 558);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label casesLabel;
        private DataGridView dataGridView;
        private Button beforeButton;
        private Button afterButton;
        private Panel panel1;
        private ComboBox ChoiceExportCases;
        private ComboBox ChoiceImportCases;
        private Button ImportCases;
        private Button ExportCases;
    }
}
