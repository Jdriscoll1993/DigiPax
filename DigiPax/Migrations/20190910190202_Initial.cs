using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiPax.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    ScreenName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MusicKey",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicKey", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SampleType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pack",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pack", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pack_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sample",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SampleName = table.Column<string>(nullable: false),
                    SamplePath = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: false),
                    SampleTypeId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false),
                    MusicKeyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sample", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sample_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sample_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sample_MusicKey_MusicKeyId",
                        column: x => x.MusicKeyId,
                        principalTable: "MusicKey",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sample_SampleType_SampleTypeId",
                        column: x => x.SampleTypeId,
                        principalTable: "SampleType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favorite",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    SampleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorite", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favorite_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Favorite_Sample_SampleId",
                        column: x => x.SampleId,
                        principalTable: "Sample",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PackSample",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PackId = table.Column<int>(nullable: false),
                    SampleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackSample", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PackSample_Pack_PackId",
                        column: x => x.PackId,
                        principalTable: "Pack",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PackSample_Sample_SampleId",
                        column: x => x.SampleId,
                        principalTable: "Sample",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ScreenName", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "00000000-ffff-ffff-ffff-ffffffffffff", 0, "6f203fa2-6cb7-4ecc-9304-f2f0f19abc45", "joey@driscoll.com", true, false, null, "JOEY@DRISCOLL.COM", "JOEYALAKING", "AQAAAAEAACcQAAAAEAENgJFD6A/KXpYQjWk9S6uRQFveShJVj9YkX243nSshwX/E+6x+aWaUSGXKoevHYw==", null, false, "Joey", "7f434309-a4d9-48e9-9ebb-8803db794577", false, "JoeyALaKing" });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 21, "Techno" },
                    { 23, "Tech House" },
                    { 24, "Deep House" },
                    { 25, "Disco" },
                    { 26, "Electro" },
                    { 27, "UK Garage" },
                    { 28, "Downtempo" },
                    { 29, "Ambient" },
                    { 30, "IDM" },
                    { 31, "Experimental" },
                    { 32, "Trip Hop" },
                    { 33, "Drum & Bass" },
                    { 34, "Breakbeat" },
                    { 35, "Jungle" },
                    { 36, "Dubstep" },
                    { 20, "Tropical House" },
                    { 19, "Future House" },
                    { 22, "House" },
                    { 17, "Trance" },
                    { 1, "Rock" },
                    { 2, "Jazz" },
                    { 3, "Blues" },
                    { 4, "Funk" },
                    { 5, "Dub" },
                    { 18, "Psytrance" },
                    { 7, "Folk" },
                    { 8, "Heavy Metal" },
                    { 6, "Reggae" },
                    { 10, "Trap" },
                    { 11, "R&B" },
                    { 12, "Soul" },
                    { 13, "Future Bass" },
                    { 14, "Glitch Hop" },
                    { 15, "Pop" },
                    { 16, "EDM" },
                    { 9, "Hip Hop" }
                });

            migrationBuilder.InsertData(
                table: "MusicKey",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 11, "Ab" },
                    { 17, "A#" },
                    { 16, "G#" },
                    { 15, "F#" },
                    { 14, "D#" },
                    { 13, "C#" },
                    { 12, "Bb" },
                    { 10, "Gb" },
                    { 8, "Db" },
                    { 7, "B" },
                    { 6, "A" },
                    { 5, "G" },
                    { 4, "F" },
                    { 3, "E" },
                    { 2, "D" },
                    { 1, "C" },
                    { 9, "Eb" }
                });

            migrationBuilder.InsertData(
                table: "SampleType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 34, "Cymbals" },
                    { 20, "Stabs" },
                    { 21, "Bells" },
                    { 22, "Textures" },
                    { 23, "Impacts" },
                    { 24, "Grooves" },
                    { 25, "Strings" },
                    { 29, "Hats" },
                    { 27, "Kicks" },
                    { 28, "Snares" },
                    { 19, "Pads" },
                    { 30, "Toms" },
                    { 31, "Claps" },
                    { 32, "Shakers" },
                    { 33, "Crashes" },
                    { 26, "Sub" },
                    { 18, "FX" },
                    { 14, "808" },
                    { 16, "Arp" },
                    { 1, "Drums" },
                    { 2, "Bass" },
                    { 3, "Synth" },
                    { 4, "Percussion" },
                    { 5, "Vocals" },
                    { 6, "Guitar" },
                    { 17, "Brass & Woodwinds" },
                    { 7, "Leads" },
                    { 9, "Ryhthm" },
                    { 10, "MusicKeys" },
                    { 11, "Risers" },
                    { 12, "Downers" },
                    { 13, "Transitions" },
                    { 15, "Piano" },
                    { 8, "Melody" },
                    { 35, "Fills" }
                });

            migrationBuilder.InsertData(
                table: "Sample",
                columns: new[] { "Id", "ApplicationUserId", "GenreId", "MusicKeyId", "SampleName", "SamplePath", "SampleTypeId" },
                values: new object[] { 1, "00000000-ffff-ffff-ffff-ffffffffffff", 1, 1, "Test Sample", "/AudioFiles", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_ApplicationUserId",
                table: "Favorite",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_SampleId",
                table: "Favorite",
                column: "SampleId");

            migrationBuilder.CreateIndex(
                name: "IX_Pack_ApplicationUserId",
                table: "Pack",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PackSample_PackId",
                table: "PackSample",
                column: "PackId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PackSample_SampleId",
                table: "PackSample",
                column: "SampleId");

            migrationBuilder.CreateIndex(
                name: "IX_Sample_ApplicationUserId",
                table: "Sample",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sample_GenreId",
                table: "Sample",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Sample_MusicKeyId",
                table: "Sample",
                column: "MusicKeyId");

            migrationBuilder.CreateIndex(
                name: "IX_Sample_SampleTypeId",
                table: "Sample",
                column: "SampleTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Favorite");

            migrationBuilder.DropTable(
                name: "PackSample");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Pack");

            migrationBuilder.DropTable(
                name: "Sample");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "MusicKey");

            migrationBuilder.DropTable(
                name: "SampleType");
        }
    }
}
