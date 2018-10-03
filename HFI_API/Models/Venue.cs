using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HFI_API.Models
{
    public class Venue
    {
        public string id { get; set; }
        public string name { get; set; }
        public int capacity { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string country { get; set; }
        public string time_zone { get; set; }
        public string sr_id { get; set; }
    }
}
