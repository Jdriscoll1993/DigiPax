using System;
using System.Collections.Generic;
using System.Text;
using DigiPax.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using DigiPax.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace DigiPax.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //Models being mapped to database
        // Core of Entity 
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Favorite> Favorite { get; set; }
        public DbSet<Sample> Sample { get; set; }
        public DbSet<PackSample> PackSample { get; set; }
        public DbSet<Pack> Pack { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<MusicKey> MusicKey { get; set; }
        public DbSet<SampleType> SampleType { get; set; }

        // seed data:
        //USER
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>()
                .HasMany(g => g.Samples)
                .WithOne(s => s.Genre)
                .HasForeignKey(s => s.GenreId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Sample>()
                 .HasOne(s => s.Genre)
                 .WithMany(g => g.Samples)
                 .HasForeignKey(s => s.GenreId)
                .OnDelete(DeleteBehavior.Restrict);

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

            modelBuilder.Entity<Sample>().HasData(
                new Sample()
                {
                    SampleName = "Test Sample",
                    SamplePath = "/AudioFiles",
                    ApplicationUserId = user.Id,
                    Id = 1,
                    SampleTypeId = 1,
                    MusicKeyId = 1,
                    GenreId = 1,
                    BPM = 100
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
                    Name = "MusicKeys"
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
            modelBuilder.Entity<MusicKey>().HasData(
                new MusicKey()
                // Root MusicKeys
                {
                    Id = 1,
                    Name = "C"
                },
                new MusicKey()
                {
                    Id = 2,
                    Name = "D"
                },
                new MusicKey()
                {
                    Id = 3,
                    Name = "E"
                },
                new MusicKey()
                {
                    Id = 4,
                    Name = "F"
                },
                new MusicKey()
                {
                    Id = 5,
                    Name = "G"
                },
                new MusicKey()
                {
                    Id = 6,
                    Name = "A"
                },
                new MusicKey()
                {
                    Id = 7,
                    Name = "B"
                },
                // Minor Keys
                new MusicKey()
                {
                    Id = 8,
                    Name = "Cm"
                },
                new MusicKey()
                {
                    Id = 9,
                    Name = "Dm"
                },
                new MusicKey()
                {
                    Id = 10,
                    Name = "Em"
                },
                new MusicKey()
                {
                    Id = 11,
                    Name = "Fm"
                },
                new MusicKey()
                {
                    Id = 12,
                    Name = "Gm"
                },
                new MusicKey()
                {
                    Id = 13,
                    Name = "Am"
                },
                new MusicKey()
                {
                    Id = 14,
                    Name = "Bm"
                },
                // Flats
                new MusicKey()
                {
                    Id = 15,
                    Name = "Db"
                },
                new MusicKey()
                {
                    Id = 16,
                    Name = "Eb"
                },
                new MusicKey()
                {
                    Id = 17,
                    Name = "Gb"
                },
                new MusicKey()
                {
                    Id = 18,
                    Name = "Ab"
                },
                new MusicKey()
                {
                    Id = 19,
                    Name = "Bb"
                },
                // Sharps
                new MusicKey()
                {
                    Id = 20,
                    Name = "C#"
                },
                new MusicKey()
                {
                    Id = 21,
                    Name = "D#"
                },
                new MusicKey()
                {
                    Id = 22,
                    Name = "F#"
                }, new MusicKey()
                {
                    Id = 23,
                    Name = "G#"
                }, new MusicKey()
                {
                    Id = 24,
                    Name = "A#"
                });
        }
    }
}



