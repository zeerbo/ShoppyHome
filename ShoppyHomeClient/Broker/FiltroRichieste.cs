using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ShoppyHomeClient.Broker
{
    public static class FiltroRichieste
    {
        private static readonly string _serverUrl = "http://localhost:50308/"; 
        private static readonly HttpClient _client = new HttpClient();

        public static async Task<Toutput> GestisciRichiesta<Toutput>(Richiesta r)
        {

            // Converte in formato Json
            var jsonInput = JsonConvert.SerializeObject(r);
            // Imposto come contenuto della richiesta l'oggetto json
            var requestContent = new StringContent(jsonInput, Encoding.UTF8, "application/json");
            // Richiesta POST asincrona al Server
            var response = await _client.PostAsync(_serverUrl + r.Destinatario + "/" + r.Servizio, requestContent);
            // Lettura in form adi stringa del content e deserializzazione

            using (var streamReader = new StreamReader(response.Content.ReadAsStreamAsync().Result))
            {
                return JsonConvert.DeserializeObject<Toutput>(response.Content.ReadAsStringAsync().Result);
            }
        }

        //Per chiamare questa procedura all'esterno
        //Toutput result = Task.Run(() => ClientServerHttp.requestAsync<Toutput>(Richiesta r)).Result;
    }
}