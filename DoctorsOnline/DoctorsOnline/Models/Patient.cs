using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorsOnline.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }
    }
}