using System.Collections.Generic;

namespace AldeloInfileFel.Domain
{
    public class InvoiceGeneration
    {
        public long OrderId { get; set; }
        public string TaxId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<OrderDetail> Details { get; set; }
    }

}
