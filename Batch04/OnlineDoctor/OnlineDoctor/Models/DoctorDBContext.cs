using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace OnlineDoctor.Models
{
    public class DoctorDBContext : IdentityDbContext<ApplicationUser>
    {
        public DoctorDBContext()
            : base("name=DefaultConnection")
        {

        }
        public DbSet<Doctor> Doctors { get; set; }
    }
}