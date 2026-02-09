using IMS.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMS.Infustructure.Data
{

    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AppDb;Integrated Security=True;TrustServerCertificate=True;");
            optionsBuilder.UseSqlite("Data Source = AppDb.db");
        }
        public DbSet<Profile> profiles { get; set; }
        public DbSet<Programs> Programs { get; set; }
    }
}
