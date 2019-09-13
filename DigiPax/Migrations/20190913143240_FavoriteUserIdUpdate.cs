using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiPax.Migrations
{
    public partial class FavoriteUserIdUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Favorite");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a30ab480-54d7-4045-802d-1100a98707a6", "AQAAAAEAACcQAAAAEHH386eyRi4aIUKcn+iBJu7kU3R3NXBtxUSfCktcm+WE5bcUJO928JuXg9/z1ONXug==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Favorite",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "516df162-039f-41f6-b067-42c35300f13b", "AQAAAAEAACcQAAAAEMNt1+evqG6LRu7Fkf58Suz05f41252yxa6jgs14lA6n+gLLFhsXey2ry9EJ0HWygQ==" });
        }
    }
}
