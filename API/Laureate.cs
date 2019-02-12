using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    public class Laureate
    {
        public string id { get; set; }
        public string firstname { get; set; }
        public string surname { get; set; }
        public string born { get; set; }
        public string died { get; set; }
        public string bornCountry { get; set; }
        public string bornCountryCode { get; set; }
        public string bornCity { get; set; }
        public string diedCountry { get; set; }
        public string diedCountryCode { get; set; }
        public string diedCity { get; set; }
        public string gender { get; set; }
        public List<Prize> prizes { get; set; }
    }
}
