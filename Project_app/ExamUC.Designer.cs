﻿namespace Project_app
{
    partial class ExamUC
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
            panel1 = new Panel();
            ChoiceExportExams = new ComboBox();
            ChoiceImportExams = new ComboBox();
            ImportExams = new Button();
            ExportExams = new Button();
            beforeButton = new Button();
            afterButton = new Button();
            dataGridView = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // examLabel
            // 
            examLabel.Dock = DockStyle.Top;
            examLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            examLabel.Location = new Point(0, 0);
            examLabel.Name = "examLabel";
            examLabel.Size = new Size(1042, 28);
            examLabel.TabIndex = 3;
            examLabel.Text = "Wyniki egzaminów maturalnych w Polsce";
            examLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(ChoiceExportExams);
            panel1.Controls.Add(ChoiceImportExams);
            panel1.Controls.Add(ImportExams);
            panel1.Controls.Add(ExportExams);
            panel1.Controls.Add(beforeButton);
            panel1.Controls.Add(afterButton);
            panel1.Location = new Point(3, 32);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 363, 0);
            panel1.Size = new Size(1035, 31);
            panel1.TabIndex = 11;
            // 
            // ChoiceExportExams
            // 
            ChoiceExportExams.FormattingEnabled = true;
            ChoiceExportExams.Items.AddRange(new object[] { "JSON", "XML", "YAML" });
            ChoiceExportExams.Location = new Point(884, 1);
            ChoiceExportExams.Name = "ChoiceExportExams";
            ChoiceExportExams.Size = new Size(151, 28);
            ChoiceExportExams.TabIndex = 16;
            ChoiceExportExams.SelectedIndex = 0;
            // 
            // ChoiceImportExams
            // 
            ChoiceImportExams.FormattingEnabled = true;
            ChoiceImportExams.Items.AddRange(new object[] { "JSON", "XML", "YAML" });
            ChoiceImportExams.Location = new Point(99, 2);
            ChoiceImportExams.Name = "ChoiceImportExams";
            ChoiceImportExams.Size = new Size(151, 28);
            ChoiceImportExams.TabIndex = 15;
            ChoiceImportExams.SelectedIndex = 0;
            // 
            // ImportExams
            // 
            ImportExams.Location = new Point(-1, 1);
            ImportExams.Name = "ImportExams";
            ImportExams.Size = new Size(94, 29);
            ImportExams.TabIndex = 14;
            ImportExams.Text = "IMPORT";
            ImportExams.UseVisualStyleBackColor = true;
            ImportExams.Click += import_Click;
            // 
            // ExportExams
            // 
            ExportExams.Location = new Point(784, 1);
            ExportExams.Name = "ExportExams";
            ExportExams.Size = new Size(94, 28);
            ExportExams.TabIndex = 13;
            ExportExams.Text = "EXPORT";
            ExportExams.UseVisualStyleBackColor = true;
            ExportExams.Click += export_Click;
            // 
            // beforeButton
            // 
            beforeButton.Dock = DockStyle.Right;
            beforeButton.Location = new Point(348, 0);
            beforeButton.Margin = new Padding(3, 4, 3, 4);
            beforeButton.Name = "beforeButton";
            beforeButton.Size = new Size(162, 31);
            beforeButton.TabIndex = 7;
            beforeButton.Text = "Dane przed 03.2020";
            beforeButton.UseVisualStyleBackColor = true;
            beforeButton.Click += beforeButton_Click;
            // 
            // afterButton
            // 
            afterButton.Dock = DockStyle.Right;
            afterButton.Location = new Point(510, 0);
            afterButton.Margin = new Padding(3, 4, 3, 4);
            afterButton.Name = "afterButton";
            afterButton.Size = new Size(162, 31);
            afterButton.TabIndex = 8;
            afterButton.Text = "Dane po 03.2020";
            afterButton.UseVisualStyleBackColor = true;
            afterButton.Click += afterButton_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(3, 71);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1035, 669);
            dataGridView.TabIndex = 10;
            // 
            // ExamUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            Controls.Add(examLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ExamUC";
            Size = new Size(1042, 744);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label examLabel;
        private Panel panel1;
        private Button beforeButton;
        private Button afterButton;
        private DataGridView dataGridView;
        private ComboBox ChoiceExportExams;
        private ComboBox ChoiceImportExams;
        private Button ImportExams;
        private Button ExportExams;
    }
}
