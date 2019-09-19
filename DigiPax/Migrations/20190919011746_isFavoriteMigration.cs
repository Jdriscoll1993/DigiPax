using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiPax.Migrations
{
    public partial class isFavoriteMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isFavorite",
                table: "Sample",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "02babcf7-53f3-4896-8aa4-5c43ea2232c7", "AQAAAAEAACcQAAAAEKVbrotGtSt5ZQylTRGHOMg0beEhnGv0LfeJw432jEXwqEOUTlx5v61c5LqQfjIRcQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isFavorite",
                table: "Sample");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "373f9eb4-3cd0-49c0-9c42-c36461155b0a", "AQAAAAEAACcQAAAAEJwj9rfmUWGfOmCAqenvWrR33LZOpRen9ijr3VpLqms2/2evp908ll7XMLHcWVhirA==" });
        }
    }
}
