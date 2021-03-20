using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AldeloInfileFel.Domain
{
    public class ItemDetail
    {
        [JsonProperty(PropertyName = "unitPrice")]
        public double UnitPrice { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public double Quantity { get; set; }

        [JsonProperty(PropertyName = "discountAmount")]
        public double DiscountAmount { get; set; }

        [JsonProperty(PropertyName = "itemText")]
        public string ItemText { get; set; }
    }
}
