using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PostbankApp.Models;

namespace PostbankApp.Data
{
    public class DWHDbContext : IdentityDbContext
    {
        public DWHDbContext(DbContextOptions<DWHDbContext> options) 
            : base(options)
        {
        }
        public DbSet<PostbankApp.Models.Test> Test { get; set; }
        public DbSet<PostbankApp.Models.Saler> Saler { get; set; }
    }
}
