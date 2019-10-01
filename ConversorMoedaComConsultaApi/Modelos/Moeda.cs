using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConversorMoedaComConsultaApi.Modelos
{
    class Moeda
    {
        [JsonProperty("code")]
        public string CodMoeda { get; set; }

        [JsonProperty("name")]
        public string NomeMoeda { get; set; }

        [JsonProperty("bid")]
        public string Cotacao { get; set; }

        [JsonProperty("create_date")]
        public DateTime DataCotacao { get; set; }
    }
}
