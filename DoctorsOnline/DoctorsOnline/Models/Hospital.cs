using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorsOnline.Models
{
    public class Hospital
    {
        public int HospitalId { get; set; }
        public string HospitatName { get; set; }
        public string Address { get; set; }
        public virtual Area Area { get; set; }
        public int ContactNo { get; set; }
        public string Email { get; set; }
    }
}