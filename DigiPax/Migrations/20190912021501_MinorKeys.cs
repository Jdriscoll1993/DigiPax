using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiPax.Migrations
{
    public partial class MinorKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "516df162-039f-41f6-b067-42c35300f13b", "AQAAAAEAACcQAAAAEMNt1+evqG6LRu7Fkf58Suz05f41252yxa6jgs14lA6n+gLLFhsXey2ry9EJ0HWygQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "17cac97d-882a-4e38-82eb-6da8fb008831", "AQAAAAEAACcQAAAAEJ/FZvWQlAZxV35R9B19y0AqSAIktrXSQAD3CZlpG4JpOUrlZW2J5erIdzaoIQS7Uw==" });

            migrationBuilder.InsertData(
                table: "MusicKey",
                columns: new[] { "Id", "Name" },
                values: new object[] { 25, "Am" });
        }
    }
}
