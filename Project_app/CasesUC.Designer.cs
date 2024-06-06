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
            casesLabel.Size = new Size(927, 21);
            casesLabel.TabIndex = 0;
            casesLabel.Text = "Zachorowania na COVID-19 w 2020 roku";
            casesLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(3, 53);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(921, 502);
            dataGridView.TabIndex = 2;
            // 
            // beforeButton
            // 
            beforeButton.Dock = DockStyle.Right;
            beforeButton.Location = new Point(319, 0);
            beforeButton.Name = "beforeButton";
            beforeButton.Size = new Size(142, 23);
            beforeButton.TabIndex = 3;
            beforeButton.Text = "Dane przed 03.2020";
            beforeButton.UseVisualStyleBackColor = true;
            beforeButton.Click += beforeButton_Click;
            // 
            // afterButton
            // 
            afterButton.Dock = DockStyle.Right;
            afterButton.Location = new Point(461, 0);
            afterButton.Name = "afterButton";
            afterButton.Size = new Size(142, 23);
            afterButton.TabIndex = 4;
            afterButton.Text = "Dane po 03.2020";
            afterButton.UseVisualStyleBackColor = true;
            afterButton.Click += afterButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(beforeButton);
            panel1.Controls.Add(afterButton);
            panel1.Location = new Point(3, 24);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 318, 0);
            panel1.Size = new Size(921, 23);
            panel1.TabIndex = 5;
            // 
            // CasesUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(dataGridView);
            Controls.Add(casesLabel);
            Name = "CasesUC";
            Size = new Size(927, 558);
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
    }
}
