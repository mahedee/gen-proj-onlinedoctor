using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int UserInfoId { get; set; }
        [ForeignKey("UserInfoId")]
        public UserInfo UserInfo { get; set; }
        public int UserPasswordId { get; set; }
        [ForeignKey("UserPasswordId")]
        public UserPassword UserPassword { get; set; }
        public int UserRoleId { get; set; }
        [ForeignKey("UserRoleId")]
        public UserRole UserRole { get; set; }
    }

}
