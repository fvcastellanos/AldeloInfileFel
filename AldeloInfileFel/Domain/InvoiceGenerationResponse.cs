using Newtonsoft.Json;
using System.Collections.Generic;

namespace AldeloInfileFel.Domain
{ 
    public class InvoiceGenerationResponse
    {
        public bool Success { get; set; }

        [JsonProperty(PropertyName = "errors")]
        public IEnumerable<string> Errors { get; set; }
        public InvoiceInformation InvoiceInformation { get; set; }
    }
}
