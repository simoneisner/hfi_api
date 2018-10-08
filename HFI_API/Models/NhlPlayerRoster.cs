using System;
namespace HFI_API.Models
{
    public class NhlPlayerRoster
    {
        public NhlPerson person { get; set; }
        public string jerseyNumber { get; set; }
        public NhlPosition position { get; set; }
    }
}
