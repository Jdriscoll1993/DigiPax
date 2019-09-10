using System;
using System.Collections.Generic;
using System.Text;
using DigiPax.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DigiPax.Models.ViewModels;

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

        // seed data:

        //user
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
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            modelBuilder.Entity<Sample>().HasData(
                new Sample()
                {
                    SampleName = "Test Sample",
                    SamplePath = "/AudioFiles",
                    ApplicationUserId = user.Id,
                    Id = 1,
                    SampleTypeId = 1,
                    KeyId = 1,
                    GenreId = 1,
                });

            //GENRE
            modelBuilder.Entity<Genre>().HasData(
                // Live Sound 
                new Genre()
                {
                    Id = 1,
                    Name = "Rock"
                },
                new Genre()
                {
                    Id = 2,
                    Name = "Jazz"
                },
                new Genre()
                {
                    Id = 3,
                    Name = "Blues"
                },
                new Genre()
                {
                    Id = 4,
                    Name = "Funk"
                },
                new Genre()
                {
                    Id = 5,
                    Name = "Dub"
                },
                new Genre()
                {
                    Id = 6,
                    Name = "Reggae"
                },
                new Genre()
                {
                    Id = 7,
                    Name = "Folk"
                },
                new Genre()
                {
                    Id = 8,
                    Name = "Heavy Metal"
                },

                // Hip Hop / R&B
                new Genre()
                {
                    Id = 9,
                    Name = "Hip Hop"
                },
                new Genre()
                {
                    Id = 10,
                    Name = "Trap"
                },
                new Genre()
                {
                    Id = 11,
                    Name = "R&B"
                },
                new Genre()
                {
                    Id = 12,
                    Name = "Soul"
                },
                new Genre()
                {
                    Id = 13,
                    Name = "Future Bass"
                },
                new Genre()
                {
                    Id = 14,
                    Name = "Glitch Hop"
                },

                // EDM / Pop
                new Genre()
                {
                    Id = 15,
                    Name = "Pop"
                }, new Genre()
                {
                    Id = 16,
                    Name = "EDM"
                },
                new Genre()
                {
                    Id = 17,
                    Name = "Trance"
                },
                new Genre()
                {
                    Id = 18,
                    Name = "Psytrance"
                }, new Genre()
                {
                    Id = 19,
                    Name = "Future House"
                },
                new Genre()
                {
                    Id = 20,
                    Name = "Tropical House"
                },

                // House/Techno
                new Genre()
                {
                    Id = 21,
                    Name = "Techno"
                },
                new Genre()
                {
                    Id = 22,
                    Name = "House"
                },
                new Genre()
                {
                    Id = 23,
                    Name = "Tech House"
                },
                new Genre()
                {
                    Id = 24,
                    Name = "Deep House"
                },
                new Genre()
                {
                    Id = 25,
                    Name = "Disco"
                },
                new Genre()
                {
                    Id = 26,
                    Name = "Electro"
                },
                new Genre()
                {
                    Id = 27,
                    Name = "UK Garage"
                },

                // Electronic
                new Genre()
                {
                    Id = 28,
                    Name = "Downtempo"
                },
                new Genre()
                {
                    Id = 29,
                    Name = "Ambient"
                },
                new Genre()
                {
                    Id = 30,
                    Name = "IDM"
                },
                new Genre()
                {
                    Id = 31,
                    Name = "Experimental"
                },
                new Genre()
                {
                    Id = 32,
                    Name = "Trip Hop"
                },

                // Bass 
                new Genre()
                {
                    Id = 33,
                    Name = "Drum & Bass"
                },
                new Genre()
                {
                    Id = 34,
                    Name = "Breakbeat"
                },
                new Genre()
                {
                    Id = 35,
                    Name = "Jungle"
                },
                new Genre()
                {
                    Id = 36,
                    Name = "Dubstep"
                });

            //TYPE
            modelBuilder.Entity<SampleType>().HasData(
                new SampleType()
                {
                    Id = 1,
                    Name = "Drums"
                },
                new SampleType()
                {
                    Id = 2,
                    Name = "Bass"
                },
                new SampleType()
                {
                    Id = 3,
                    Name = "Synth"
                },
                new SampleType()
                {
                    Id = 4,
                    Name = "Percussion"
                },
                new SampleType()
                {
                    Id = 5,
                    Name = "Vocals"
                },
                new SampleType()
                {
                    Id = 6,
                    Name = "Guitar"
                },
                new SampleType()
                {
                    Id = 7,
                    Name = "Leads"
                },
                new SampleType()
                {
                    Id = 8,
                    Name = "Melody"
                },
                new SampleType()
                {
                    Id = 9,
                    Name = "Ryhthm"
                },
                new SampleType()
                {
                    Id = 10,
                    Name = "Keys"
                },
                new SampleType()
                {
                    Id = 11,
                    Name = "Risers"
                },
                new SampleType()
                {
                    Id = 12,
                    Name = "Downers"
                },
                new SampleType()
                {
                    Id = 13,
                    Name = "Transitions"
                },
                new SampleType()
                {
                    Id = 14,
                    Name = "808"
                },
                new SampleType()
                {
                    Id = 15,
                    Name = "Piano"
                },
                new SampleType()
                {
                    Id = 16,
                    Name = "Arp"
                },
                new SampleType()
                {
                    Id = 17,
                    Name = "Brass & Woodwinds"
                },
                new SampleType()
                {
                    Id = 18,
                    Name = "FX"
                },
                new SampleType()
                {
                    Id = 19,
                    Name = "Pads"
                },
                new SampleType()
                {
                    Id = 20,
                    Name = "Stabs"
                },
                new SampleType()
                {
                    Id = 21,
                    Name = "Bells"
                },
                new SampleType()
                {
                    Id = 22,
                    Name = "Textures"
                },
                new SampleType()
                {
                    Id = 23,
                    Name = "Impacts"
                },
                new SampleType()
                {
                    Id = 24,
                    Name = "Grooves"
                },
                new SampleType()
                {
                    Id = 25,
                    Name = "Strings"
                },
                new SampleType()
                {
                    Id = 26,
                    Name = "Sub"
                },
                new SampleType()
                {
                    Id = 27,
                    Name = "Kicks"
                },
                new SampleType()
                {
                    Id = 28,
                    Name = "Snares"
                },
                new SampleType()
                {
                    Id = 29,
                    Name = "Hats"
                },
                new SampleType()
                {
                    Id = 30,
                    Name = "Toms"
                },
                new SampleType()
                {
                    Id = 31,
                    Name = "Claps"
                },
                new SampleType()
                {
                    Id = 32,
                    Name = "Shakers"
                },
                new SampleType()
                {
                    Id = 33,
                    Name = "Crashes"
                },
                new SampleType()
                {
                    Id = 34,
                    Name = "Cymbals"
                },
                new SampleType()
                {
                    Id = 35,
                    Name = "Fills"
                });

            //KEY
            modelBuilder.Entity<Key>().HasData(
                new Key()
                // Root Keys
                {
                    Id = 1,
                    Name = "C"
                },
                new Key()
                {
                    Id = 2,
                    Name = "D"
                },
                new Key()
                {
                    Id = 3,
                    Name = "E"
                },
                new Key()
                {
                    Id = 4,
                    Name = "F"
                },
                new Key()
                {
                    Id = 5,
                    Name = "G"
                },
                new Key()
                {
                    Id = 6,
                    Name = "A"
                },
                new Key()
                {
                    Id = 7,
                    Name = "B"
                },
                // Flats
                new Key()
                {
                    Id = 8,
                    Name = "Db"
                },
                new Key()
                {
                    Id = 9,
                    Name = "Eb"
                },
                new Key()
                {
                    Id = 10,
                    Name = "Gb"
                },
                new Key()
                {
                    Id = 11,
                    Name = "Ab"
                },
                new Key()
                {
                    Id = 12,
                    Name = "Bb"
                },
                // Sharps
                new Key()
                {
                    Id = 13,
                    Name = "C#"
                },
                new Key()
                {
                    Id = 14,
                    Name = "D#"
                },
                new Key()
                {
                    Id = 15,
                    Name = "F#"
                }, new Key()
                {
                    Id = 16,
                    Name = "G#"
                }, new Key()
                {
                    Id = 17,
                    Name = "A#"
                });
        }
    }
}



