using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostbankApp.Models
{
    public class CardUser : PostbankUser
    {
        public int CardNumber { get; set; }

        public CardUser() { }
    }
}
