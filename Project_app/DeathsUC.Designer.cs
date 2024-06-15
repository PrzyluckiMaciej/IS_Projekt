﻿namespace Project_app
{
    partial class DeathsUC
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
            deathsLabel = new Label();
            afterButton = new Button();
            beforeButton = new Button();
            dataGridView = new DataGridView();
            panel1 = new Panel();
            ChoiceExportDeaths = new ComboBox();
            ChoiceImportDeaths = new ComboBox();
            ImportDeaths = new Button();
            ExportDeaths = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // deathsLabel
            // 
            deathsLabel.Dock = DockStyle.Top;
            deathsLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            deathsLabel.Location = new Point(0, 0);
            deathsLabel.Name = "deathsLabel";
            deathsLabel.Size = new Size(1042, 28);
            deathsLabel.TabIndex = 1;
            deathsLabel.Text = "Śmierci na COVID-19 w 2020 roku";
            deathsLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // afterButton
            // 
            afterButton.Dock = DockStyle.Right;
            afterButton.Location = new Point(510, 0);
            afterButton.Margin = new Padding(3, 4, 3, 4);
            afterButton.Name = "afterButton";
            afterButton.Size = new Size(162, 31);
            afterButton.TabIndex = 6;
            afterButton.Text = "Dane po 03.2020";
            afterButton.UseVisualStyleBackColor = true;
            afterButton.Click += afterButton_Click;
            // 
            // beforeButton
            // 
            beforeButton.Dock = DockStyle.Right;
            beforeButton.Location = new Point(348, 0);
            beforeButton.Margin = new Padding(3, 4, 3, 4);
            beforeButton.Name = "beforeButton";
            beforeButton.Size = new Size(162, 31);
            beforeButton.TabIndex = 5;
            beforeButton.Text = "Dane przed 03.2020";
            beforeButton.UseVisualStyleBackColor = true;
            beforeButton.Click += beforeButton_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(3, 71);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1035, 669);
            dataGridView.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(ChoiceExportDeaths);
            panel1.Controls.Add(ChoiceImportDeaths);
            panel1.Controls.Add(ImportDeaths);
            panel1.Controls.Add(ExportDeaths);
            panel1.Controls.Add(beforeButton);
            panel1.Controls.Add(afterButton);
            panel1.Location = new Point(3, 32);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 363, 0);
            panel1.Size = new Size(1035, 31);
            panel1.TabIndex = 8;
            // 
            // ChoiceExportDeaths
            // 
            ChoiceExportDeaths.FormattingEnabled = true;
            ChoiceExportDeaths.Items.AddRange(new object[] { "JSON", "XML", "YAML" });
            ChoiceExportDeaths.Location = new Point(884, 1);
            ChoiceExportDeaths.Name = "ChoiceExportDeaths";
            ChoiceExportDeaths.Size = new Size(151, 28);
            ChoiceExportDeaths.TabIndex = 12;
            ChoiceExportDeaths.SelectedIndex = 0;
            // 
            // ChoiceImportDeaths
            // 
            ChoiceImportDeaths.FormattingEnabled = true;
            ChoiceImportDeaths.Items.AddRange(new object[] { "JSON", "XML", "YAML" });
            ChoiceImportDeaths.Location = new Point(99, 2);
            ChoiceImportDeaths.Name = "ChoiceImportDeaths";
            ChoiceImportDeaths.Size = new Size(151, 28);
            ChoiceImportDeaths.TabIndex = 11;
            ChoiceImportDeaths.SelectedIndex = 0;
            // 
            // ImportDeaths
            // 
            ImportDeaths.Location = new Point(-1, 1);
            ImportDeaths.Name = "ImportDeaths";
            ImportDeaths.Size = new Size(94, 29);
            ImportDeaths.TabIndex = 10;
            ImportDeaths.Text = "IMPORT";
            ImportDeaths.UseVisualStyleBackColor = true;
            ImportDeaths.Click += import_Click;
            // 
            // ExportDeaths
            // 
            ExportDeaths.Location = new Point(784, 1);
            ExportDeaths.Name = "ExportDeaths";
            ExportDeaths.Size = new Size(94, 28);
            ExportDeaths.TabIndex = 9;
            ExportDeaths.Text = "EXPORT";
            ExportDeaths.UseVisualStyleBackColor = true;
            ExportDeaths.Click += export_Click;
            // 
            // DeathsUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(dataGridView);
            Controls.Add(deathsLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DeathsUC";
            Size = new Size(1042, 744);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label deathsLabel;
        private Button afterButton;
        private Button beforeButton;
        private DataGridView dataGridView;
        private Panel panel1;
        private ComboBox ChoiceExportDeaths;
        private ComboBox ChoiceImportDeaths;
        private Button ImportDeaths;
        private Button ExportDeaths;
    }
}
