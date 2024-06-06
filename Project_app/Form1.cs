namespace Project_app
{
    public partial class Form1 : Form
    {
        MainView mainView;
        CasesUC casesUC;
        DeathsUC deathsUC;
        ExamUC examUC;
        GraphUC graphUC;
        public Form1()
        {
            mainView = new MainView();
            casesUC = new CasesUC();
            deathsUC = new DeathsUC();
            examUC = new ExamUC();
            graphUC = new GraphUC();
            InitializeComponent();
        }

        private void hideUC()
        {
            mainViewUC.Visible = false;
            mainView.Visible = false;
            casesUC.Visible = false;
            deathsUC.Visible = false;
            examUC.Visible = false;
            graphUC.Visible = false;
        }

        private void casesButton_Click(object sender, EventArgs e)
        {
            hideUC();
            casesUC.Visible = true;
            contentPanel.Controls.Add(casesUC);
        }

        private void mainPageLabel_Click(object sender, EventArgs e)
        {
            hideUC();
            mainView.Visible = true;
            contentPanel.Controls.Add(mainView);
        }

        private void deathsButton_Click(object sender, EventArgs e)
        {
            hideUC();
            deathsUC.Visible = true;
            contentPanel.Controls.Add(deathsUC);
        }

        private void examButton_Click(object sender, EventArgs e)
        {
            hideUC();
            examUC.Visible = true;
            contentPanel.Controls.Add(examUC);
        }

        private void graphButton_Click(object sender, EventArgs e)
        {
            hideUC();
            graphUC.Visible = true;
            contentPanel.Controls.Add(graphUC);
        }
    }
}