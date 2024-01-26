using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;

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
                StringContent request = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response =  restClient.PostAsync(uri, request).Result;
                if (response.IsSuccessStatusCode)
                    return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"Error al iniciar sesion {0}", ex.Message);
            }
            return string.Empty;
        }

        public async Task<string> JornadaActiva(string grupo)
        {
            Uri uri = new Uri($"{domain}{configuration["jornadaActiva"]}?grupo={grupo}");
            try
            {
                restClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Preferences.Get("token", string.Empty));
                HttpResponseMessage response = restClient.GetAsync(uri).Result;
                if (response.IsSuccessStatusCode)
                    return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"Error al consultar la jornada activa {0}", ex.Message);
            }
            return string.Empty;
        }

        public async Task<string> CrearJornada(string grupo, string nombre, DateTime fechaCierre)
        {
            Uri uri = new Uri($"{domain}{configuration["crearJornada"]}");
            try
            {
                string json = new
                {
                    nombre = nombre,
                    grupo = grupo,
                    fechaCierre = fechaCierre.ToString("yyyy-MM-dd hh:mm:ss")
                }.ToJson();
                StringContent request = new StringContent(json, Encoding.UTF8, "application/json");
                restClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Preferences.Get("token", string.Empty));
                HttpResponseMessage response = restClient.PostAsync(uri, request).Result;
                if (response.IsSuccessStatusCode)
                    return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"Error al iniciar sesion {0}", ex.Message);
            }
            return string.Empty;
        }
    }
}
