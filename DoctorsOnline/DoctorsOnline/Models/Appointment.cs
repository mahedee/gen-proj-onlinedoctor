using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineDoctor.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int SerialNo { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual Chamber Chamber { get; set; }
        public DateTime Date { get; set; }
        public DateTime TimeFrom { get; set; }
        public DateTime TimeTo { get; set; }
    }
}