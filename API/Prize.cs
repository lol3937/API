using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    public class Prize
    {
        public string year { get; set; }
        public string category { get; set; }
        public string share { get; set; }
        public string motivation { get; set; }
        public List<object> affiliations { get; set; }
        public string overallMotivation { get; set; }
    }
}
