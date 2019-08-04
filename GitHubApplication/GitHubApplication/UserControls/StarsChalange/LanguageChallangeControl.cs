using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GitHubApplication.API;
using GitHubApplication.Models;
using GitHubApplication.UserControls.StarsChalange;

namespace GitHubApplication.UserControls
{
    public partial class LanguageChallangeControl : UserControl
    {
        public bool Indicator { get; set; } = true;
        LanguageChallangeData languageChallangeData=new LanguageChallangeData();
        HttpApiClient Client;

        public LanguageChallangeControl(HttpApiClient apiClient)
        {
            InitializeComponent();
            Client = apiClient;
        }


        private async void Compare_Click(object sender, EventArgs e)
        {

            

            var Firstresponse = await Client.GetTrendingRepositories(languageChallangeData.FirstChoosedLanguage, DateTime.Now.Subtract(new TimeSpan(7, 0, 0, 0)).ToString("yyyy-MM-dd"));
            var Secondresponse = await Client.GetTrendingRepositories(languageChallangeData.SecondChoosedLanguage, DateTime.Now.Subtract(new TimeSpan(7, 0, 0, 0, 0)).ToString("yyyy-MM-dd"));

            if (Firstresponse != null&& Secondresponse != null)
            {
                
                var firstresult = Firstresponse.items.Select(r => r.stargazers_count);
                languageChallangeData.FirstStarsCount = firstresult.Aggregate((Result,Item)=>Result+Item);

                var secondresult = Secondresponse.items.Select(r => r.stargazers_count);
                languageChallangeData.SecondStarsCount = secondresult.Aggregate((Result, Item) => Result + Item);

                ShowchallengeResult repoControls = new ShowchallengeResult(languageChallangeData);
                ChalangeResultPanel.Controls.Add(repoControls);
                NewChallange.Enabled = true;
                Compare.Enabled = false;
            }
        }

        private void Java_Click(object sender, EventArgs e)
        {
            if (languageChallangeData.FirstChoosedLanguage != null)
            {
                languageChallangeData.SecondChoosedLanguage = "Java";
                //SecondLanguage.Text = "Java";
                Java.Enabled = false;
                Compare.Enabled = true;
            }
            if (languageChallangeData.FirstChoosedLanguage == null)
            {
                languageChallangeData.FirstChoosedLanguage = "Java";
                //FirstLanguage.Text = "Java";
                Java.Enabled = false;
            }

        }

        private void Ruby_Click(object sender, EventArgs e)
        {


            if (languageChallangeData.FirstChoosedLanguage != null)
            {
                languageChallangeData.SecondChoosedLanguage = "ruby";
                //SecondLanguage.Text = "ruby";
                Ruby.Enabled = false;
                Compare.Enabled = true;


            }
            if (languageChallangeData.FirstChoosedLanguage == null)
            {
                languageChallangeData.FirstChoosedLanguage = "ruby";
                //FirstLanguage.Text = "ruby";
                Ruby.Enabled = false;
            }
           
        }

        private void LanguageChallangeControl_Load(object sender, EventArgs e)
        {

        }

        private void SecondLanguage_Click(object sender, EventArgs e)
        {

        }

        private void FirstLanguage_Click(object sender, EventArgs e)
        {

        }

        private void C_Click(object sender, EventArgs e)
        {

            if (languageChallangeData.FirstChoosedLanguage != null)
            {
                languageChallangeData.SecondChoosedLanguage = "C";
                //SecondLanguage.Text = "C";
                C.Enabled = false;
                Compare.Enabled = true;


            }
            if (languageChallangeData.FirstChoosedLanguage == null)
            {
                languageChallangeData.FirstChoosedLanguage = "C";
                //FirstLanguage.Text = "C";
                C.Enabled = false;
            }
        }

        private void C_Sharp_Click(object sender, EventArgs e)
        {
            if (languageChallangeData.FirstChoosedLanguage != null)
            {
                languageChallangeData.SecondChoosedLanguage = ".NET";
                //SecondLanguage.Text = "C#";
                C_Sharp.Enabled = false;
                Compare.Enabled = true;


            }
            if (languageChallangeData.FirstChoosedLanguage == null)
            {
                languageChallangeData.FirstChoosedLanguage = ".NET";
                //FirstLanguage.Text = "C#";
                C_Sharp.Enabled = false;
            }
        }

        private void NewChallange_Click(object sender, EventArgs e)
        {
            ChalangeResultPanel.Controls.Clear();
            C_Sharp.Enabled = true;
            C.Enabled = true;
            Java.Enabled = true;
            Ruby.Enabled = true;
            Compare.Enabled = false;


        }

        private void Python_Click(object sender, EventArgs e)
        {
            if (languageChallangeData.FirstChoosedLanguage != null)
            {
                languageChallangeData.SecondChoosedLanguage = "Python";
                //SecondLanguage.Text = "Python";
                Python.Enabled = false;
                Compare.Enabled = true;


            }
            if (languageChallangeData.FirstChoosedLanguage == null)
            {
                languageChallangeData.FirstChoosedLanguage = "Python";
                //FirstLanguage.Text = "Python";
                Python.Enabled = false;
            }

        }
    }
    }
