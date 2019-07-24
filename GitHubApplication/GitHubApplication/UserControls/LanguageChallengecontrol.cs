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
    public partial class LanguagesChallengecontrol : UserControl
    {
        HttpApiClient client;

        public LanguagesChallengecontrol(HttpApiClient apiClient)
        {
            InitializeComponent();
            client = apiClient;
        }

        private void LanguagesChallengecontrol_Load(object sender, EventArgs e)
        {

        }
       

        private void TradingControl_Load(object sender, EventArgs e)
        {

            //dateComboBox.DataSource = timeValuePairs.Keys.ToList();
            //languageComboBox.DataSource = Languages;


        }
        

        private async void compare_Click(object sender, EventArgs e)
        {
  

        var response = await client.GetTrendingRepositories("java", "2019-07-23");
        if (response != null)
        {
            var repos = response.items;


          //LanguagesChallengecontrol repoControls = repos.Select(r => { return new LanguagesChallengecontrol; }).ToArray();
       

        }
   
            //searchResultPanel.Controls.Clear();
            //searchResultPanel.Controls.AddRange(repoControls);
        }
    }
    }
}
