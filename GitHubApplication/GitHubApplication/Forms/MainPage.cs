using GitHubApplication.Common;
using GitHubApplication.Forms;
using GitHubApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using GitHubApplication.UserControls;
using GitHubApplication.API;

namespace GitHubApplication
{
    public partial class MainPage : Form
    {
        User user;
        public event EventHandler<User> CurrentUser;

        public object TrendingReposControl { get; private set; }

        public MainPage()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void MenuBar_click(object sender, EventArgs e)
        {
            Size size = new Size(180,675);
           
            MenuBar.Size = size;
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            var loginForm = ServiceManager.Instance.Container.Resolve<LoginForm>();
            loginForm.SuccessfulLogin += OnSuccesfulLogin;
            DialogResult result = loginForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                loginForm.SuccessfulLogin -= OnSuccesfulLogin;
            }
            else if (result == DialogResult.Cancel)
            {
                Close();
            }

        }

        private void OnSuccesfulLogin(object sender, User e)
        {
            user = e;
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            Control control = new Control();
         

        }

        private void Bookmarks_label_Click(object sender, EventArgs e)
        {

        }

        private void Settings_label_Click(object sender, EventArgs e)
        {
            
        }

        private void Profile_label_Click(object sender, EventArgs e)
        {
            UserPage userPage = ServiceManager.Instance.Container.Resolve<UserPage>();
            CurrentUser += userPage.GetUser;
            CurrentUser.Invoke(this, user); 
            userPage.ShowDialog();
        }

        private void ResultPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void TradingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Trading_label_Click(object sender, EventArgs e)
        {
            TrendingReposControl trendingControl = new TrendingReposControl(new HttpApiClient());

            generalPanel.Controls.Clear();
            generalPanel.Controls.Add(trendingControl);
        }

        private void Statistics_label_Click(object sender, EventArgs e)
        {
            //LanguageChallengform statistic = new LanguageChallengform();
            //statistic.Show();
        }

        private void StarsCHallange_label_Click(object sender, EventArgs e)
        {
            LanguageChallangeControl languagesChallengecontrol = new LanguageChallangeControl(new HttpApiClient());

            generalPanel.Controls.Add(languagesChallengecontrol);
        }
    }
}
