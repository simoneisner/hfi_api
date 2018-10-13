using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HFI_API.Models.NHL
{
    public class NhlTeamList
    {
        public string copyright { get; set; }
        public List<NhlTeam> teams { get; set; }
    }
}
