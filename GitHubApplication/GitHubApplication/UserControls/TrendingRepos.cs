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
    public partial class TrendingRepos : UserControl
    {

        HttpApiClient client;
        Dictionary<string, string> TimePeriodPairs;


        public TrendingRepos()
        {
            InitializeComponent();
            TimePeriodPairs = new Dictionary<string, string>()
            {
                ["1 Day"] = DateTime.Now.ToString("YYYY-MM-DD"),
                ["1 Week"] = DateTime.Now.Subtract(new TimeSpan(7, 0, 0, 0)).ToString(),
                ["1 Month"] = DateTime.Now.Subtract(new TimeSpan(30, 0, 0, 0)).ToString(),
            };
            


        }
    }
}
