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
        HttpApiClient Client;

        public LanguageChallangeControl(HttpApiClient apiClient)
        {
            InitializeComponent();
            Client = apiClient;
        }

        private async void Compare_Click(object sender, EventArgs e)
        {

            var response = await Client.GetTrendingRepositories("java", "2019-07-22");
            if (response != null)
            {
                var repos = response.items;
                ShowchallengeResult[] repoControls = repos.Select(r => new ShowchallengeResult(r)).ToArray();

               

                //LanguageChallangeResult.Controls.Clear();
                //LanguageChallangeResult.Controls.AddRange(repoControls);




            }
        }

        private void ChallangeResultControl_Load(object sender, EventArgs e)
        {

        }
    }
    }
