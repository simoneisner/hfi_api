using System;
using System.Collections.Generic;

namespace HFI_API.Models.NHL
{
    public class NhlRoster
    {
        public string copyright { get; set; }
        public List<NhlPlayer> roster { get; set; }
        public string link { get; set; }
    }
}
