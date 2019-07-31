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



            var Firstresponse = await Client.GetTrendingRepositories(languageChallangeData.FirstChoosedLanguage, DateTime.Now.Subtract(new TimeSpan(1, 0, 0, 0, 0)).ToString("yyyy-MM-dd"));
            var Secondresponse = await Client.GetTrendingRepositories(languageChallangeData.SecondChoosedLanguage, DateTime.Now.Subtract(new TimeSpan(1, 0, 0, 0, 0)).ToString("yyyy-MM-dd"));

            if (Firstresponse != null&& Secondresponse != null)
            {
                
                var firstresult = Firstresponse.items.Select(r => r.stargazers_count);
                languageChallangeData.FirstStarsCount = firstresult.Aggregate((Result,Item)=>Result+Item);

                var secondresult = Secondresponse.items.Select(r => r.stargazers_count);
                languageChallangeData.SecondStarsCount = secondresult.Aggregate((Result, Item) => Result + Item);

                ShowchallengeResult repoControls = new ShowchallengeResult(languageChallangeData);
                ChalangeResultPanel.Controls.Add(repoControls);

            }
        }

        private void Java_Click(object sender, EventArgs e)
        {
            if (!Indicator)
            {
                Java.ForeColor = System.Drawing.Color.Red;
                languageChallangeData.SecondChoosedLanguage = "Java";
                SecondLanguage.Text = "Java";
                Java.Enabled = false;
                Indicator = true;
                Compare.Enabled = true;
            }
            if (Indicator)
            {
                Java.ForeColor = System.Drawing.Color.Red;
                languageChallangeData.FirstChoosedLanguage = "Java";
                FirstLanguage.Text = "Java";
                Java.Enabled = false;
                Indicator = false;
            }

        }

        private void Ruby_Click(object sender, EventArgs e)
        {


            if (!Indicator)
            {
                Ruby.ForeColor = System.Drawing.Color.Red;
                languageChallangeData.SecondChoosedLanguage = "Ruby";
                SecondLanguage.Text = "Ruby";
                Ruby.Enabled = false;
                Indicator = true;
                Compare.Enabled = true;


            }
            if (Indicator)
            {
                Ruby.ForeColor = System.Drawing.Color.Red;
                languageChallangeData.FirstChoosedLanguage = "Ruby";
                FirstLanguage.Text = "Ruby";
                Ruby.Enabled = false;
                Indicator = false;
            }
           

            //ChalangeResultPanel.Controls.Clear();

        }

        private void LanguageChallangeControl_Load(object sender, EventArgs e)
        {

        }
    }
    }
