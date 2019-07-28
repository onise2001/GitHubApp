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

namespace GitHubApplication.UserControls
{
    public partial class LanguageChallangeControl : UserControl
    {
        string ChoisedLanguage;
        HttpApiClient Client;

        public LanguageChallangeControl(HttpApiClient apiClient)
        {
            InitializeComponent();
            Client = apiClient;
        }

        private async void Compare_Click(object sender, EventArgs e)
        {


            var response = await Client.GetTrendingRepositories("", DateTime.Now.Subtract(new TimeSpan(1, 0, 0, 0, 0)).ToString("yyyy-MM-dd"));
            if (response != null)
            {
                var repos = response.items;
                var result= repos.Select(r => r.stargazers_count);
               var starscount=result.Aggregate((Result,Item)=>Result+Item);

                ShowchallengeResult repoControls = new ShowchallengeResult(starscount);
                ChalangeResultPanel.Controls.Add(repoControls);


                  
            }
        }

        private void ChallangeResultControl_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ChalangeResultPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Java_Click(object sender, EventArgs e)
        {
            ChoisedLanguage = "Java";
            ChalangeResultPanel.Controls.Clear();

        }

        private void Ruby_Click(object sender, EventArgs e)
        {
            ChoisedLanguage = "Ruby";
            ChalangeResultPanel.Controls.Clear();

        }
    }
    }
