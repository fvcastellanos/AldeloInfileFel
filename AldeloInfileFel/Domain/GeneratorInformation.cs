using System.Collections.Generic;

namespace AldeloInfileFel.Domain
{
    public class GeneratorInformation
    {
        public string SubscriptionType { get; set; }
        public string TaxId { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string CompanyName { get; set; }
        public IList<Phrase> Phrases { get; set; }
    }

}
