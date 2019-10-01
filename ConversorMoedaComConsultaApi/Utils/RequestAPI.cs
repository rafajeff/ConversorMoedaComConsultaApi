using ConversorMoedaComConsultaApi.Modelos;
using Newtonsoft.Json;
using RestSharp;

namespace ConversorMoedaComConsultaApi.Utils
{
    class RequestAPI
    {
        private static string _urlAPI = "https://economia.awesomeapi.com.br";

        public ResultApi Request(string resource, Method method)
        {
            var client = new RestClient(_urlAPI);
            var request = new RestRequest(resource, method);
            var queryresult = client.Execute(request).Content;
            return JsonConvert.DeserializeObject<ResultApi>(queryresult);
        }
    }
}
