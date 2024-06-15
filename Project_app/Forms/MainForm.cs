using Project_app.Authentication;

namespace Project_app
{
    public partial class MainForm : Form
    {
        MainView mainView;
        CasesUC casesUC;
        DeathsUC deathsUC;
        ExamUC examUC;
        GraphUC graphUC;
        User user;
        public MainForm(User user)
        {
            mainView = new MainView(user);
            casesUC = new CasesUC();
            deathsUC = new DeathsUC();
            examUC = new ExamUC();
            graphUC = new GraphUC();
            this.user = user;
            InitializeComponent();
            ucPanel.Controls.Add(mainView);
        }

        private void hideUC()
        {
            //mainViewUC.Visible = false;
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
            ucPanel.Controls.Add(casesUC);
        }

        private void mainPageLabel_Click(object sender, EventArgs e)
        {
            hideUC();
            mainView.Visible = true;
            ucPanel.Controls.Add(mainView);
        }

        private void deathsButton_Click(object sender, EventArgs e)
        {
            hideUC();
            deathsUC.Visible = true;
            ucPanel.Controls.Add(deathsUC);
        }

        private void examButton_Click(object sender, EventArgs e)
        {
            hideUC();
            examUC.Visible = true;
            ucPanel.Controls.Add(examUC);
        }

        private void graphButton_Click(object sender, EventArgs e)
        {
            hideUC();
            graphUC.Visible = true;
            ucPanel.Controls.Add(graphUC);
        }
    }
}
