using Newtonsoft.Json;
using System;

namespace ApiCovid.Dominio.Objetos_base
{
    public class CovidResponse
    {
        [JsonProperty("Country")]
        public string Country { get; set; }
        [JsonProperty("CountryCode")]
        public string CountryCode { get; set; }
        [JsonProperty("Lat")]
        public string Lat { get; set; }
        [JsonProperty("Lon")]
        public string Lon { get; set; }
        [JsonProperty("Cases")]
        public int Cases { get; set; }
        [JsonProperty("Status")]
        public string Status { get; set; }
        [JsonProperty("Date")]
        public DateTime Date { get; set; }
    }
}
