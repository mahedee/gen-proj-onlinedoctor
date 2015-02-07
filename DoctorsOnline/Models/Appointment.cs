using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Appointment
    {
        public int Id { get; set; }
        public int AppointmentNo { get; set; }
        public DateTime AppointmentTime { get; set; }
        public bool IsActive { get; set; }
        public virtual DoctorsInfo DoctorsInfo { get; set; }
        public Patient Patient { get; set; }

    }

}
