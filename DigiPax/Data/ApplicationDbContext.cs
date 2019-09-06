using System;
using System.Collections.Generic;
using System.Text;
using DigiPax.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DigiPax.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Favorite> Favorite { get; set; }
        public DbSet<Sample> Sample { get; set; }
        public DbSet<PackSample> PackSample { get; set; }
        public DbSet<Pack> Pack { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Key> Key { get; set; }
        public DbSet<SampleType> SampleType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}


