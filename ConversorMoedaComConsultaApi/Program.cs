using ConversorMoedaComConsultaApi.Modelos;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace ConversorMoedaComConsultaApi
{
    class Program
    {
        private static string _urlAPI = "https://economia.awesomeapi.com.br";

        static void Main(string[] args)
        {
            var client = new RestClient(_urlAPI);
            var request = new RestRequest("all/USD");
            var queryresult = client.Execute(request).Content;
            ResultApi resultado = JsonConvert.DeserializeObject<ResultApi>(queryresult);

            decimal valor, resultadoconversao;
            string op;

            Console.WriteLine("Digite o tipo de moeda que deseja converter");
            Console.WriteLine("\nUSD Dolar");
            op = Console.ReadLine();

            Console.WriteLine("Digite o valor em Reais");
            valor = decimal.Parse (Console.ReadLine());

            switch (op)
            {
                case "USD":
                    resultadoconversao = decimal.Parse (resultado.USD.Cotacao) * valor;
                    Console.WriteLine($"O Resultado é :R$ {resultadoconversao:N2} na data de : {resultado.USD.DataCotacao.ToString("dd/MM/yyyy HH:mm")}");
                    break;
                default:
                    break;
            }

        }
    }
}
