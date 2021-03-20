using Newtonsoft.Json;
using System.Collections.Generic;

namespace AldeloInfileFel.Domain
{
    class InvoiceGenerationErrorResponse
    {
        [JsonProperty(PropertyName = "errors")]
        public IEnumerable<string> Errors { get; set; }
    }
}
