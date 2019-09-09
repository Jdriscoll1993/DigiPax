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
                    ApplicationUserId = "",
                    TypeId = 1,
                    KeyId = 1,
                    GenreId = 1,
                });

            //genre
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
                } );

            //type
            modelBuilder.Entity<SampleType>().HasData(
                new SampleType()
                {
                    Id = 1,
                    Name = "Drums"
                },
                new SampleType()
                {
                    Id = 1,
                    Name = "Bass"
                },
                new SampleType()
                {
                    Id = 1,
                    Name = "Synth"
                },
                new SampleType()
                {
                    Id = 1,
                    Name = "Percussion"
                },
                new SampleType()
                {
                    Id = 1,
                    Name = "Vocals"
                },
                new SampleType()
                {
                    Id = 1,
                    Name = "Guitar"
                },
                new SampleType()
                {
                    Id = 1,
                    Name = "Leads"
                },
                new SampleType()
                {
                    Id = 1,
                    Name = "Melody"
                },
                new SampleType()
                {
                    Id = 1,
                    Name = "Keys"
                },
                new SampleType()
                {
                    Id = 1,
                    Name = "Risers"
                },
                new SampleType()
                {
                    Id = 1,
                    Name = "808"
                },
                new SampleType()
                {
                    Id = 1,
                    Name = "Piano"
                },
                new SampleType()
                {
                    Id = 1,
                    Name = "Arp"
                },
                new SampleType()
                {
                    Id = 1,
                    Name = "Brass & Woodwinds"
                },
                new SampleType()
                {
                    Id = 1,
                    Name = "FX"
                },
                new SampleType()
                {
                    Id = 1,
                    Name = "Pads"
                },
                new SampleType()
                {
                    Id = 1,
                    Name = "Stabs"
                },
                new SampleType()
                {
                    Id = 1,
                    Name = "Bells"
                },
                new SampleType()
                {
                    Id = 1,
                    Name = "Textures"
                },
                new SampleType()
                {
                    Id = 1,
                    Name = "Impacts"
                },
                new SampleType()
                {
                    Id = 1,
                    Name = "Grooves"
                },
                new SampleType()
                {
                    Id = 1,
                    Name = "Strings"
                },
                new SampleType()
                {
                    Id = 1,
                    Name = "Sub"
                },
                new SampleType()
                {
                    Id = 1,
                    Name = "Kicks"
                }, 
                new SampleType()
                {
                    Id = 1,
                    Name = "Snares"
                }, 
                new SampleType()
                {
                    Id = 1,
                    Name = "Hats"
                },
                new SampleType()
                {
                    Id = 1,
                    Name = "Toms"
                },
                new SampleType()
                {
                    Id = 1,
                    Name = "Claps"
                },
                new SampleType()
                {
                    Id = 1,
                    Name = "Shakers"
                },
                new SampleType()
                {
                    Id = 1,
                    Name = "Crashes"
                },

                new SampleType()
                {
                    Id = 1,
                    Name = "Fills"
                },


            //key
            modelBuilder.Entity<Key>().HasData(
                new Key()
                {
                    Id = 1,
                    Name = "Bb"
                });
            );
        }
    }
}


