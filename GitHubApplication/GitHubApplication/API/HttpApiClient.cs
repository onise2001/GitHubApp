using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using GitHubApplication.Models;
using Newtonsoft.Json;

namespace GitHubApplication.API
{
    public class HttpApiClient
    {
        readonly string baseUrl = "https://api.github.com";
        public HttpClient client { get; set; }

        public HttpApiClient()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("GitHubApplication", "1.0.0"));
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public async Task SendRequest()
        {
            var result = await client.GetAsync($"{baseUrl}/search");
            var content = await result.Content.ReadAsStringAsync();

        }



        public async Task<ReposRootObject> GetTrendingRepositories(string language, string date)
        {
            using (HttpResponseMessage response = await client.GetAsync($"{baseUrl}/search/repositories?q=language:{language}+created:>={date}"))
            {
                if (response.IsSuccessStatusCode)
                {
                    string resposAsString = await response.Content.ReadAsStringAsync();
                    ReposRootObject repos = JsonConvert.DeserializeObject<ReposRootObject>(resposAsString);
                    return repos;
                }

            }

            return null;
        }


        public async Task<UsersRootObject> GetPopularUsers(string language, string date)
        {
            using (HttpResponseMessage response = await client.GetAsync($"{baseUrl}/user_search_url/q=language:{language}+sort:followers"))
            {
                if (response.IsSuccessStatusCode)
                {
                    string usersAsString = await response.Content.ReadAsStringAsync();
                    UsersRootObject users = JsonConvert.DeserializeObject<UsersRootObject>(usersAsString);
                    return users;
                }
            }

            return null;
        }




    }
}
