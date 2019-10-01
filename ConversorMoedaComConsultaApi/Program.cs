using ConversorMoedaComConsultaApi.Modelos;
using ConversorMoedaComConsultaApi.Utils;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace ConversorMoedaComConsultaApi
{
    class Program
    {
        static void Main(string[] args)
        {
            RequestAPI request = new RequestAPI();
            ResultApi resultado = new ResultApi();

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
                    resultado = request.Request($"all/{op}", Method.GET);
                    resultadoconversao = decimal.Parse(resultado.USD.Cotacao) * valor;
                    Console.WriteLine($"O Resultado é :R$ {resultadoconversao:N2} na data de : {resultado.USD.DataCotacao.ToString("dd/MM/yyyy HH:mm")}");
                    break;
                default:
                    break;
            }

        }
    }
}
