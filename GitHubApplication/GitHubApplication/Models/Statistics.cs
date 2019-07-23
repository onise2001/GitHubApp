using GitHubApplication.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubApplication.Models
{
    class Statistics
    {

        public static async Task<int> Getstars()
        {
            HttpApiClient httpclient = new HttpApiClient();
            var data = await httpclient.GetTrendingRepositories();

            var stars = data.items.Select(a => a.stargazers_count).ToArray();

            var starssum = stars.Aggregate((a,b)=>a+b);

            return starssum;
        }
        
    }
}
