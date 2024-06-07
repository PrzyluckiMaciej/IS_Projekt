namespace Project_app
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
            deathsLabel.Size = new Size(912, 21);
            deathsLabel.TabIndex = 1;
            deathsLabel.Text = "Śmierci na COVID-19 w 2020 roku";
            deathsLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // afterButton
            // 
            afterButton.Dock = DockStyle.Right;
            afterButton.Location = new Point(446, 0);
            afterButton.Name = "afterButton";
            afterButton.Size = new Size(142, 23);
            afterButton.TabIndex = 6;
            afterButton.Text = "Dane po 03.2020";
            afterButton.UseVisualStyleBackColor = true;
            afterButton.Click += afterButton_Click;
            // 
            // beforeButton
            // 
            beforeButton.Dock = DockStyle.Right;
            beforeButton.Location = new Point(304, 0);
            beforeButton.Name = "beforeButton";
            beforeButton.Size = new Size(142, 23);
            beforeButton.TabIndex = 5;
            beforeButton.Text = "Dane przed 03.2020";
            beforeButton.UseVisualStyleBackColor = true;
            beforeButton.Click += beforeButton_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(3, 53);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(906, 502);
            dataGridView.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(beforeButton);
            panel1.Controls.Add(afterButton);
            panel1.Location = new Point(3, 24);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 318, 0);
            panel1.Size = new Size(906, 23);
            panel1.TabIndex = 8;
            // 
            // DeathsUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(dataGridView);
            Controls.Add(deathsLabel);
            Name = "DeathsUC";
            Size = new Size(912, 558);
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
    }
}
