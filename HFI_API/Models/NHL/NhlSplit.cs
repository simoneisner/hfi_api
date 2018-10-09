using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HFI_API.Models.NHL
{
    public class NhlSplit
    {
        public string season { get; set; }
        public NhlStat2 stat { get; set; }
    }
}
