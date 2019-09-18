using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiPax.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PackSample_PackId",
                table: "PackSample");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "373f9eb4-3cd0-49c0-9c42-c36461155b0a", "AQAAAAEAACcQAAAAEJwj9rfmUWGfOmCAqenvWrR33LZOpRen9ijr3VpLqms2/2evp908ll7XMLHcWVhirA==" });

            migrationBuilder.CreateIndex(
                name: "IX_PackSample_PackId",
                table: "PackSample",
                column: "PackId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PackSample_PackId",
                table: "PackSample");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d0669e1e-f534-4c7c-b76a-b957985f3136", "AQAAAAEAACcQAAAAENQ75XC5Az5ykr0/aWhqTDnPDEvqqfvkJVrqz9vpwliTFyaN1ABCCYC6qahuZw4Lew==" });

            migrationBuilder.CreateIndex(
                name: "IX_PackSample_PackId",
                table: "PackSample",
                column: "PackId",
                unique: true);
        }
    }
}
