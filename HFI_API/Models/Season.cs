using System;
using System.Collections.Generic;

namespace HFI_API.Models
{
    public class Season
    {
        public string id { get; set; }
        public int year { get; set; }
        public string type { get; set; }
        public List<Team> teams { get; set; }
    }
}
