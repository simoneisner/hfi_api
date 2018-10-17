using System.Collections.Generic;

namespace HFI_API.Models.NHL
{
    public class NhlPersonContainer
    {
        public string copyright { get; set; }
        public List<NhlPerson> people { get; set; }
    }
}
