using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AldeloInfileFel.Domain
{
    public class CertificationResult
    {
        public bool Success { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public InvoiceInformation InvoiceInformation { get; set; }
    }
}
