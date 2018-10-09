using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HFI_API.Models.NHL;

namespace HFI_API.Models.HFI
{
    public class Player
    {
        public NhlPlayer nhlPlayer { get; set; }
        public NhlPlayerStatsContainer nhlPlayerStatsContainer { get; set; }
    }
}
