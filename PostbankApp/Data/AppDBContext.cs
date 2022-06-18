using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using PostbankApp.Models;

namespace PostbankApp.Data
{
    public class AppDBContext : IdentityDbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {

        }
        public DbSet<Saler> Salers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<CardUser> CardUsers { get; set; }
        public DbSet<PostbankApp.Models.Sale> Sale { get; set; }
    }
}