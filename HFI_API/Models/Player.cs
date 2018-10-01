using System;
using System.Collections.Generic;

namespace HFI_API.Models
{
    public class Player
    {
        public string id { get; set; }
        public string status { get; set; }
        public string full_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string abbr_name { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
        public string handedness { get; set; }
        public string position { get; set; }
        public string primary_position { get; set; }
        public string jersey_number { get; set; }
        public string college { get; set; }
        public string experience { get; set; }
        public string birth_place { get; set; }
        public string birthdate { get; set; }
        public DateTime updated { get; set; }
        public League league { get; set; }
        public Draft draft { get; set; }
        public List<Season> seasons { get; set; }
    }
}
