using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using PostbankApp.Models;

namespace PostbankApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<PostbankUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Saler> Salers { get; set; }
    }
}
