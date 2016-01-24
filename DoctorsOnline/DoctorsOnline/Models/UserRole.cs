using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorsOnline.Models
{
    public class UserRole
    {
        public int UserRoleId { get; set; }
        public ApplicationUser User { get; set; }
        public Role Role { get; set; }
        public bool IsActive { get; set; }
    }
}