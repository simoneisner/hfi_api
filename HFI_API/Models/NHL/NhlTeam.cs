using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HFI_API.Models.NHL
{
    public class NhlTeam
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public NhlVenue venue { get; set; }
        public string abbreviation { get; set; }
        public string teamName { get; set; }
        public string locationName { get; set; }
        public string firstYearOfPlay { get; set; }
        public NhlDivision division { get; set; }
        public NhlConference conference { get; set; }
        public NhlFranchise franchise { get; set; }
        public string shortName { get; set; }
        public string officialSiteUrl { get; set; }
        public int franchiseId { get; set; }
        public bool active { get; set; }
    }
}
