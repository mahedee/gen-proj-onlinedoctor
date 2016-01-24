using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace DoctorsOnline.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}