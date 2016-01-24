using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoctorsOnline.Controllers;

namespace DoctorsOnline.Models
{
    public class UserPassword
    {
        public int PasswordId { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}