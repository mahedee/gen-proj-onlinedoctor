using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorsOnline.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<Area> Areas { get; set; }
    }
}