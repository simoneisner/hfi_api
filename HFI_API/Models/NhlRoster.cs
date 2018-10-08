using System;
using System.Collections.Generic;

namespace HFI_API.Models
{
    public class NhlRoster
    {
        public string copyright { get; set; }
        public List<NhlPlayerRoster> playerRoster { get; set; }
        public string link { get; set; }
    }
}
