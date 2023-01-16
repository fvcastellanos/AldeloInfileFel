
using Newtonsoft.Json;

namespace AldeloInfileFel.Domain
{
    public class IdResponse
    {
        [JsonProperty("cui")]
        public string Id { get; set; }

        [JsonProperty("nombre")]
        public string Name { get; set; }

        [JsonProperty("fallecido")]
        public string Dead { get; set; }

    }
}
