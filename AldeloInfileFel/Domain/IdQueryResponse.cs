
using Newtonsoft.Json;
using System;

namespace AldeloInfileFel.Domain
{
    public class IdQueryResponse
    {
        [JsonProperty("fecha")]
        public DateTime Date { get; set; }

        [JsonProperty("resultado")]
        public bool Result { get; set; }

        [JsonProperty("descripcion")]
        public string Description { get; set; }

        [JsonProperty("cui")]
        public IdResponse Id { get; set; }
    }
}
