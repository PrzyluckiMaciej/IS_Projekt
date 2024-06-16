using Project_app.Authentication;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project_app
{
    public partial class MainForm : Form
    {
        MainView mainView;
        CasesUC casesUC;
        DeathsUC deathsUC;
        ExamUC examUC;
        SummaryUC summaryUC;
        User user;
        public MainForm(User user)
        {
            this.user = user;
            mainView = new MainView(user);
            casesUC = new CasesUC(user.token);
            deathsUC = new DeathsUC(user.token);
            examUC = new ExamUC(user.token);
            summaryUC = new SummaryUC(user.token);
            InitializeComponent();
            ucPanel.Controls.Add(mainView);
        }

        private void hideUC()
        {
            mainView.Visible = false;
            casesUC.Visible = false;
            deathsUC.Visible = false;
            examUC.Visible = false;
            summaryUC.Visible = false;
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

        private void summaryButton_Click(object sender, EventArgs e)
        {
            hideUC();
            summaryUC.Visible = true;
            ucPanel.Controls.Add(summaryUC);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            user.token = "";
            AuthForm auth = new AuthForm();
            auth.ShowDialog();
            this.Close();
        }
    }
}
