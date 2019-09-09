using System;
using System.Collections.Generic;
using System.Text;
using DigiPax.Models;
using Microsoft.AspNetCore.Identity;
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
            ApplicationUser user = new ApplicationUser
            {
                ScreenName = "Joey",
                UserName = "JoeyALaKing",
                NormalizedUserName = "JOEYALAKING",
                Email = "joey@driscoll.com",
                NormalizedEmail = "JOEY@DRISCOLL.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };

            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Password");
            ModelBuilder.Entity<ApplicationUser>().HasData(user);


            modelBuilder.Entity<Genre>().HasData(
                new Genre()
                {
                    Id = 1,
                    Name = "Rock"
                });

            modelBuilder.Entity<Key>().HasData(
                new Key()
                {
                    Id = 1,
                    Name = "Bb"
                });
            modelBuilder.Entity<SampleType>().HasData(
                new SampleType()
                {
                    Id = 1,
                    Name = "Drums"
                }
            );
        }
    }
}


