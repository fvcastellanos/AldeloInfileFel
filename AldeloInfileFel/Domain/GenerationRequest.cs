using Newtonsoft.Json;
using System.Collections.Generic;

namespace AldeloInfileFel.Domain
{
    public class GenerationRequest
    {
        [JsonProperty("invoices")]
        public IEnumerable<InvoiceGenerationRequest> Invoices { get; set; }
    }
}
