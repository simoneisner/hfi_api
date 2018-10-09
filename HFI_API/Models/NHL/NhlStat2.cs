using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HFI_API.Models.NHL
{
    public class NhlStat2
    {
        public string timeOnIce { get; set; }
        public int assists { get; set; }
        public int goals { get; set; }
        public int pim { get; set; }
        public int shots { get; set; }
        public int games { get; set; }
        public int hits { get; set; }
        public int powerPlayGoals { get; set; }
        public int powerPlayPoints { get; set; }
        public string powerPlayTimeOnIce { get; set; }
        public string evenTimeOnIce { get; set; }
        public string penaltyMinutes { get; set; }
        public double faceOffPct { get; set; }
        public double shotPct { get; set; }
        public int gameWinningGoals { get; set; }
        public int overTimeGoals { get; set; }
        public int shortHandedGoals { get; set; }
        public int shortHandedPoints { get; set; }
        public string shortHandedTimeOnIce { get; set; }
        public int blocked { get; set; }
        public int plusMinus { get; set; }
        public int points { get; set; }
        public int shifts { get; set; }
        public string timeOnIcePerGame { get; set; }
        public string evenTimeOnIcePerGame { get; set; }
        public string shortHandedTimeOnIcePerGame { get; set; }
        public string powerPlayTimeOnIcePerGame { get; set; }
    }
}
