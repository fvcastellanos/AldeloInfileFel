using Newtonsoft.Json;
using System.Collections.Generic;

namespace AldeloInfileFel.Domain
{
    public class GenerationResponse
    {
        [JsonProperty("invoices")]
        public IEnumerable<InvoiceInformation> Invoices { get; set; }
    }
}
