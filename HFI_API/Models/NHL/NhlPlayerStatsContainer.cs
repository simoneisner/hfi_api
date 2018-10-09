using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HFI_API.Models.NHL
{
    public class NhlPlayerStatsContainer
    {
        public string copyright { get; set; }
        public List<NhlStat> stats { get; set; }
    }
}
