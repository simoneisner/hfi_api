using System;
namespace HFI_API.Models.NHL
{
    public class NhlPlayer
    {
        public NhlPerson person { get; set; }
        public string jerseyNumber { get; set; }
        public NhlPosition position { get; set; }
    }
}
