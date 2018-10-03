using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HFI_API.Models
{
    public class Coach
    {
        public string id { get; set; }
        public string full_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string position { get; set; }
        public string experience { get; set; }
    }
}
