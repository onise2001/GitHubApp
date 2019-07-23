using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GitHubApplication.Models;
using GitHubApplication.API;

namespace GitHubApplication.UserControls
{
    public partial class TrendingReposControl : UserControl
    {
        HttpApiClient client;

        bool repoButtonClicked;
        bool devButtonClicked;


        Dictionary<string, string> timeValuePairs = new Dictionary<string, string>()
        {
            ["Today"] = DateTime.Now.ToString("YYYY-MM-DD"),
            ["1 Week"] = DateTime.Now.Subtract(new TimeSpan(7, 0, 0, 0)).ToString("YYYY-MM-DD"),
            ["1 Month"] = DateTime.Now.Subtract(new TimeSpan(30,0,0,0)).ToString("YYYY-MM-DD"), 

        };




        public TrendingReposControl(HttpApiClient apiClient)
        {
            InitializeComponent();
            client = apiClient;
        }

        private void reposButton_Click(object sender, EventArgs e)
        {
            repoButtonClicked = true;
            devButtonClicked = false;

        }



        private void TradingControl_Load(object sender, EventArgs e)
        {
            dateComboBox.DataSource = timeValuePairs.Keys;

        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            if (repoButtonClicked)
            {
                var response = await client.GetTrendingRepositories(languageComboBox.SelectedItem.ToString(), dateComboBox.SelectedItem.ToString());
                if (response != null)
                {
                    var repos = response.items;
                    ViewRepoControl[] repoControls = repos.Select(r => { return new ViewRepoControl(r); }).ToArray();
                    searchResultPanel.Controls.AddRange(repoControls);
                }
            }


        }

        private void developersButton_Click(object sender, EventArgs e)
        {
            repoButtonClicked = false;
            devButtonClicked = true;
        }
    }
}
