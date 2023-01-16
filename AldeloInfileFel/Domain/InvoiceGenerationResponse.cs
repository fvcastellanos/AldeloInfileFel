using Newtonsoft.Json;
using System.Collections.Generic;

namespace AldeloInfileFel.Domain
{ 
    public class InvoiceGenerationResponse
    {
        public bool Success { get; set; }

        [JsonProperty(PropertyName = "errors")]
        public IEnumerable<string> Errors { get; set; }

        [JsonProperty("invoices")]
        public IEnumerable<InvoiceInformation> Invoices { get; set; }
    }
}
