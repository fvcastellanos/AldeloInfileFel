
using Newtonsoft.Json;
using System;

namespace AldeloInfileFel.Domain
{
    public class QueryIdLoginResponse
    {
        [JsonProperty("fecha")]
        public DateTime Date { get; set; }

        [JsonProperty("resultado")]
        public bool Result { get; set; }

        [JsonProperty("descripcion")]
        public string Description { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("fecha_de_vencimiento")]
        public DateTime ExpiresOn { get; set; }
    }
}
