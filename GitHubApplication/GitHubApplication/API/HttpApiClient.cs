using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;


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



        


    }
}
