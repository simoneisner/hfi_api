namespace HFI_API.Models
{
    public class NhlVenue
    {
        public string name { get; set; }
        public string link { get; set; }
        public string city { get; set; }
        public NhlTimeZone timeZone { get; set; }
        public int? id { get; set; }
    }
}