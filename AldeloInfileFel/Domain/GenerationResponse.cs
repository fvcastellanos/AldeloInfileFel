using System.Collections.Generic;

namespace AldeloInfileFel.Domain
{
    public class GenerationResponse
    {
        public IEnumerable<InvoiceInformation> Invoices { get; set; }
    }
}
