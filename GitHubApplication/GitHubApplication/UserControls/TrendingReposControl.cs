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


        List<string> Languages = new List<string>()
        {
            "C#","C++","JavaScript","Python","Java","Ruby","PHP","Html","F#"
        };



        Dictionary<string, string> timeValuePairs = new Dictionary<string, string>()
        {
            ["Today"] = DateTime.Now.Subtract(new TimeSpan(1,0,0,0,0)).ToString("yyyy-MM-dd"),
            ["1 Week"] = DateTime.Now.Subtract(new TimeSpan(7, 0, 0, 0)).ToString("yyyy-MM-dd"),
            ["1 Month"] = DateTime.Now.Subtract(new TimeSpan(30,0,0,0)).ToString("yyyy-MM-dd"), 

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
            dateComboBox.DataSource = timeValuePairs.Keys.ToList();
            languageComboBox.DataSource = Languages;

        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            if (repoButtonClicked)
            {
                var date = timeValuePairs[dateComboBox.SelectedItem.ToString()];

                var response = await client.GetTrendingRepositories(languageComboBox.SelectedItem.ToString(), date);
                if (response != null)
                {
                    var repos = response.items;
                    ViewRepoControl[] repoControls = repos.Select(r => { return new ViewRepoControl(r); }).ToArray();
                    searchResultPanel.Controls.Clear();
                    searchResultPanel.Controls.AddRange(repoControls);
                }
            }

            else if(devButtonClicked)
            {
                var date = timeValuePairs[dateComboBox.SelectedItem.ToString()];

                var response = await client.GetPopularUsers( languageComboBox.SelectedItem.ToString(), date);
                if (response != null)
                {
                    var users = response.items;
                    DevelopersControl[] devControls = users.Select(u => { return new DevelopersControl(u); }).ToArray();
                    searchResultPanel.Controls.Clear();
                    searchResultPanel.Controls.AddRange(devControls);
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
