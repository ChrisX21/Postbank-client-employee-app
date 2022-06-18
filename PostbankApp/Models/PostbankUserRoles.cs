using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostbankApp.Models
{
    public enum UserRoles 
    {
        Employee = 0,
        Seller,
        CardUser
    }

    public class PostbankUserRole : IdentityRole
    {
        public PostbankUserRole() { }
    }
}
