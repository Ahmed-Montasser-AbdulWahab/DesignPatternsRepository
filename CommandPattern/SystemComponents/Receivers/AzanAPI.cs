using System.Text.Json;
using SystemComponents.Interfaces;

namespace SystemComponents.Receivers{
    public class AzanAPI : API
    {
        public async Task<Dictionary<string, object>?> getData()
        {
            using HttpClient httpClient = new HttpClient() ;

            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(){
                    RequestUri = new Uri("http://api.aladhan.com/v1/timingsByCity?city=Cairo&country=Egypt&method=5"),
                    Method = HttpMethod.Get
            };

            var response = await httpClient.SendAsync(httpRequestMessage);

            var responseAsString = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<Dictionary<string, object>>(responseAsString);


            
        }
    }
}