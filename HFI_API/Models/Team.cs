using System;
using System.Collections.Generic;

namespace HFI_API.Models
{
    public class Team
    {
        public string id { get; set; }
        public string name { get; set; }
        public string market { get; set; }
        public string alias { get; set; }
        public string sr_id { get; set; }
        public string reference { get; set; }
        public Venue venue { get; set; }
        public League league { get; set; }
        public Conference conference { get; set; }
        public Division division { get; set; }
        public List<Coach> coaches { get; set; }
        public List<Player> players { get; set; }
    }
}
