﻿// <auto-generated />
using System;
using DigiPax.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DigiPax.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190919011746_isFavoriteMigration")]
    partial class isFavoriteMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DigiPax.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("ScreenName")
                        .IsRequired();

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "00000000-ffff-ffff-ffff-ffffffffffff",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "02babcf7-53f3-4896-8aa4-5c43ea2232c7",
                            Email = "joey@driscoll.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "JOEY@DRISCOLL.COM",
                            NormalizedUserName = "JOEYALAKING",
                            PasswordHash = "AQAAAAEAACcQAAAAEKVbrotGtSt5ZQylTRGHOMg0beEhnGv0LfeJw432jEXwqEOUTlx5v61c5LqQfjIRcQ==",
                            PhoneNumberConfirmed = false,
                            ScreenName = "Joey",
                            SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                            TwoFactorEnabled = false,
                            UserName = "JoeyALaKing"
                        });
                });

            modelBuilder.Entity("DigiPax.Models.Favorite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId");

                    b.Property<int>("SampleId");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("SampleId");

                    b.ToTable("Favorite");
                });

            modelBuilder.Entity("DigiPax.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Genre");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Rock"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Jazz"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Blues"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Funk"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Dub"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Reggae"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Folk"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Heavy Metal"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Hip Hop"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Trap"
                        },
                        new
                        {
                            Id = 11,
                            Name = "R&B"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Soul"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Future Bass"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Glitch Hop"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Pop"
                        },
                        new
                        {
                            Id = 16,
                            Name = "EDM"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Trance"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Psytrance"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Future House"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Tropical House"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Techno"
                        },
                        new
                        {
                            Id = 22,
                            Name = "House"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Tech House"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Deep House"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Disco"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Electro"
                        },
                        new
                        {
                            Id = 27,
                            Name = "UK Garage"
                        },
                        new
                        {
                            Id = 28,
                            Name = "Downtempo"
                        },
                        new
                        {
                            Id = 29,
                            Name = "Ambient"
                        },
                        new
                        {
                            Id = 30,
                            Name = "IDM"
                        },
                        new
                        {
                            Id = 31,
                            Name = "Experimental"
                        },
                        new
                        {
                            Id = 32,
                            Name = "Trip Hop"
                        },
                        new
                        {
                            Id = 33,
                            Name = "Drum & Bass"
                        },
                        new
                        {
                            Id = 34,
                            Name = "Breakbeat"
                        },
                        new
                        {
                            Id = 35,
                            Name = "Jungle"
                        },
                        new
                        {
                            Id = 36,
                            Name = "Dubstep"
                        });
                });

            modelBuilder.Entity("DigiPax.Models.MusicKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("MusicKey");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "C"
                        },
                        new
                        {
                            Id = 2,
                            Name = "D"
                        },
                        new
                        {
                            Id = 3,
                            Name = "E"
                        },
                        new
                        {
                            Id = 4,
                            Name = "F"
                        },
                        new
                        {
                            Id = 5,
                            Name = "G"
                        },
                        new
                        {
                            Id = 6,
                            Name = "A"
                        },
                        new
                        {
                            Id = 7,
                            Name = "B"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Cm"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Dm"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Em"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Fm"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Gm"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Am"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Bm"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Db"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Eb"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Gb"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Ab"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Bb"
                        },
                        new
                        {
                            Id = 20,
                            Name = "C#"
                        },
                        new
                        {
                            Id = 21,
                            Name = "D#"
                        },
                        new
                        {
                            Id = 22,
                            Name = "F#"
                        },
                        new
                        {
                            Id = 23,
                            Name = "G#"
                        },
                        new
                        {
                            Id = 24,
                            Name = "A#"
                        });
                });

            modelBuilder.Entity("DigiPax.Models.Pack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Pack");
                });

            modelBuilder.Entity("DigiPax.Models.PackSample", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PackId");

                    b.Property<int>("SampleId");

                    b.HasKey("Id");

                    b.HasIndex("PackId");

                    b.HasIndex("SampleId");

                    b.ToTable("PackSample");
                });

            modelBuilder.Entity("DigiPax.Models.Sample", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .IsRequired();

                    b.Property<int>("BPM");

                    b.Property<int>("GenreId");

                    b.Property<int>("MusicKeyId");

                    b.Property<string>("SampleName")
                        .IsRequired();

                    b.Property<string>("SamplePath");

                    b.Property<int>("SampleTypeId");

                    b.Property<bool?>("isFavorite");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("GenreId");

                    b.HasIndex("MusicKeyId");

                    b.HasIndex("SampleTypeId");

                    b.ToTable("Sample");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApplicationUserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            BPM = 100,
                            GenreId = 1,
                            MusicKeyId = 1,
                            SampleName = "Test Sample",
                            SamplePath = "/AudioFiles",
                            SampleTypeId = 1
                        });
                });

            modelBuilder.Entity("DigiPax.Models.SampleType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("SampleType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Drums"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bass"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Synth"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Percussion"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Vocals"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Guitar"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Leads"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Melody"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Ryhthm"
                        },
                        new
                        {
                            Id = 10,
                            Name = "MusicKeys"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Risers"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Downers"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Transitions"
                        },
                        new
                        {
                            Id = 14,
                            Name = "808"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Piano"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Arp"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Brass & Woodwinds"
                        },
                        new
                        {
                            Id = 18,
                            Name = "FX"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Pads"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Stabs"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Bells"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Textures"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Impacts"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Grooves"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Strings"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Sub"
                        },
                        new
                        {
                            Id = 27,
                            Name = "Kicks"
                        },
                        new
                        {
                            Id = 28,
                            Name = "Snares"
                        },
                        new
                        {
                            Id = 29,
                            Name = "Hats"
                        },
                        new
                        {
                            Id = 30,
                            Name = "Toms"
                        },
                        new
                        {
                            Id = 31,
                            Name = "Claps"
                        },
                        new
                        {
                            Id = 32,
                            Name = "Shakers"
                        },
                        new
                        {
                            Id = 33,
                            Name = "Crashes"
                        },
                        new
                        {
                            Id = 34,
                            Name = "Cymbals"
                        },
                        new
                        {
                            Id = 35,
                            Name = "Fills"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DigiPax.Models.Favorite", b =>
                {
                    b.HasOne("DigiPax.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("DigiPax.Models.Sample", "Sample")
                        .WithMany()
                        .HasForeignKey("SampleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DigiPax.Models.Pack", b =>
                {
                    b.HasOne("DigiPax.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Packs")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("DigiPax.Models.PackSample", b =>
                {
                    b.HasOne("DigiPax.Models.Pack", "Pack")
                        .WithMany("PackSamples")
                        .HasForeignKey("PackId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DigiPax.Models.Sample", "Sample")
                        .WithMany("PackSamples")
                        .HasForeignKey("SampleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DigiPax.Models.Sample", b =>
                {
                    b.HasOne("DigiPax.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Samples")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DigiPax.Models.Genre", "Genre")
                        .WithMany("Samples")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DigiPax.Models.MusicKey", "MusicKey")
                        .WithMany("Samples")
                        .HasForeignKey("MusicKeyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DigiPax.Models.SampleType", "SampleType")
                        .WithMany("Samples")
                        .HasForeignKey("SampleTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DigiPax.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DigiPax.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DigiPax.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DigiPax.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
