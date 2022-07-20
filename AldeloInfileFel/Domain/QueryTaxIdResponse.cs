using Newtonsoft.Json;

namespace AldeloInfileFel.Domain
{
    class QueryTaxIdResponse
    {
        [JsonProperty("nit")]
        public string TaxId { get; set; }

        [JsonProperty("nombre")]
        public string Name { get; set; }

        [JsonProperty("mensaje")]
        public string Message { get; set; }
    }
}
