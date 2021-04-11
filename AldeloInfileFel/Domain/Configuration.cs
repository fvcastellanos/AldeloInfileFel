using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AldeloInfileFel.Domain
{
    public class Configuration
    {
        public string AldeloDbConnectionString { get; set; }
        public string FelApiUrl { get; set; }
        public string FelApiHealth { get; set; }
        public string FelApiInfo { get; set; }
        public string TipDescription { get; set; }
        public string PreviewUrl { get; set; }
        public string TipAmountQuery { get; set; }
    }
}
