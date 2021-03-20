using AldeloInfileFel.Domain;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AldeloInfileFel.Domain
{
    public class InvoiceGenerationRequest
    {
        [JsonProperty(PropertyName = "orderId")]
        public long OrderId { get; set; }

        [JsonProperty(PropertyName = "taxId")]
        public string TaxId { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "details")]
        public IEnumerable<ItemDetail> Details { get; set; }
    }
}
