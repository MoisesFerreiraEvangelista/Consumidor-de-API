using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace API.Consumer
{
    public class API
    {       
        public static T Consumir<T>(string uri, string rota)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(uri);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync($"{rota}").Result;

                if (response.IsSuccessStatusCode)
                {
                    var retorno = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<T>(retorno);
                }

                throw new Exception();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
