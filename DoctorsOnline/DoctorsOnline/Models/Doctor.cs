using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace OnlineDoctor.Models
{
    public class Doctor: ApplicationUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string Qualification { get; set; }
        public string RegistrationNo { get; set; }
        public virtual Department Department { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual List<ChamberTimeTable> AvailableTimeTable { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }

        
    }
}