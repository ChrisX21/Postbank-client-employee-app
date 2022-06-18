using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostbankApp.Models
{
    public class PostbankUser : IdentityUser
    {
        public DateTime RegisterDate { get; set; }
        public UserRoles Roles { get; set;   }

        public PostbankUser()
            : base() { }
    }
}
