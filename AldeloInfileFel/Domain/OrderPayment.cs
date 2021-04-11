using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AldeloInfileFel.Domain
{
    public class OrderPayment
    {
        public long OrderId { get; set; }
        public double AmountPaid { get; set; }
        public double EmployeeComp { get; set; }

    }
}
