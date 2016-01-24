using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorsOnline.Models
{
    public class Area
    {
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public virtual City City { get; set; }
        public short PostCode { get; set; }
        public virtual ICollection<Hospital> Hospitals { get; set; }

    }
}