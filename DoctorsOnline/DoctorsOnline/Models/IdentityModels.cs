using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace DoctorsOnline.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FathersName { get; set; }
        public string MothersName { get; set; }
        public DateTime BirthDay { get; set; }
        public int NationalIdNo { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public virtual Area Area { get; set; }
        public bool Gender { get; set; }
        public string Occupation { get; set; }
        public int CityId { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public bool IsActive { get; set; }

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
        }
    }
}