using System.Collections.Generic;


namespace OnlineDoctor.Models
{
    public class Chamber
    {
        public int ChamberId { get; set; }
        public string Name { get; set; }
        public virtual Area Area { get; set; }
        public string Address { get; set; }
        public virtual List<ChamberTimeTable> AvailableTimeTable { get; set; }
    }
}
