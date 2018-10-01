using System;
namespace HFI_API.Models
{
    public class Team
    {
        public string id { get; set; }
        public string name { get; set; }
        public string market { get; set; }
        public string alias { get; set; }
        public string sr_id { get; set; }
        public Statistics statistics { get; set; }
        public TimeOnIce time_on_ice { get; set; }
    }
}
