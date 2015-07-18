using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineDoctor.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }

    }
}
