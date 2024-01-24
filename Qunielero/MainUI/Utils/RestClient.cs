using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Quinieleros.Utils
{
    public class RestClient : IRestClient
    {

        public IConfiguration configuration { get; }
        private HttpClient restClient;
        private string domain;
        public RestClient(IConfiguration config)
        {
            ConfigureRestClient();
            configuration = config;
            domain = configuration["domain"];
        }
        private void ConfigureRestClient() 
        {
            restClient = new HttpClient();
            restClient.Timeout = TimeSpan.FromMinutes(1);
        }

        public async Task<string> Logine(string user, string password)
        {
            Uri uri = new Uri($"{domain}{configuration["login"]}");
            try
            {
                string json = new
                {
                    uss = user,
                    pss = password
                }.ToJson();

                StringContent request = new StringContent(
                    json, Encoding.UTF8, "application/json");

                HttpResponseMessage response =  restClient.PostAsync(uri, request).Result;
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"Error al iniciar sesion {0}", ex.Message);
            }
            return string.Empty;
        }
    }
}
