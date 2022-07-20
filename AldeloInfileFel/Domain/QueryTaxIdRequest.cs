using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AldeloInfileFel.Domain
{
    class QueryTaxIdRequest
    {
        [JsonProperty("emisor_codigo")]
        public string TenantCode { get; set; }

        [JsonProperty("emisor_clave")]
        public string TenantKey { get; set; }

        [JsonProperty("nit_consulta")]
        public string TaxId { get; set; }
    }
}
