﻿namespace Project_app
{
    partial class MainView
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
            mainDescriptionLabel = new Label();
            authorsLabel = new Label();
            columnButton = new Button();
            SuspendLayout();
            // 
            // mainDescriptionLabel
            // 
            mainDescriptionLabel.Anchor = AnchorStyles.Right;
            mainDescriptionLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            mainDescriptionLabel.ForeColor = SystemColors.ActiveCaptionText;
            mainDescriptionLabel.Location = new Point(250, 0);
            mainDescriptionLabel.Name = "mainDescriptionLabel";
            mainDescriptionLabel.Size = new Size(674, 166);
            mainDescriptionLabel.TabIndex = 1;
            mainDescriptionLabel.Text = "Zestawienie różnych danych statystycznych przed wybuchem pandemii COVID-19 (przed 03.2020 r.) oraz w czasie jej trwania (po 03.2020 r.), prezentacja zmian wartości w wybranym okresie.";
            mainDescriptionLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // authorsLabel
            // 
            authorsLabel.Anchor = AnchorStyles.Right;
            authorsLabel.AutoSize = true;
            authorsLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            authorsLabel.Location = new Point(768, 256);
            authorsLabel.Name = "authorsLabel";
            authorsLabel.Size = new Size(156, 75);
            authorsLabel.TabIndex = 2;
            authorsLabel.Text = "Autorzy:\r\nPatryk Przybyś\r\nMaciej Przyłucki";
            authorsLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // columnButton
            // 
            columnButton.Location = new Point(808, 334);
            columnButton.Name = "columnButton";
            columnButton.Size = new Size(75, 23);
            columnButton.TabIndex = 3;
            columnButton.Text = "Eksportuj";
            columnButton.UseVisualStyleBackColor = true;
            columnButton.Click += columnButton_Click;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(columnButton);
            Controls.Add(authorsLabel);
            Controls.Add(mainDescriptionLabel);
            Name = "MainView";
            Size = new Size(927, 558);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainDescriptionLabel;
        private Label authorsLabel;
        private Button columnButton;
    }
}
