using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HFI_API.Models.NHL
{
    public class NhlStat
    {
        public class Stat
        {
            public NhlType type { get; set; }
            public List<NhlSplit> splits { get; set; }
        }
    }
}
