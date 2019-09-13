using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiPax.Migrations
{
    public partial class UpdatingSeedInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "17cac97d-882a-4e38-82eb-6da8fb008831", "AQAAAAEAACcQAAAAEJ/FZvWQlAZxV35R9B19y0AqSAIktrXSQAD3CZlpG4JpOUrlZW2J5erIdzaoIQS7Uw==" });

            migrationBuilder.UpdateData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Cm");

            migrationBuilder.UpdateData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Dm");

            migrationBuilder.UpdateData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Em");

            migrationBuilder.UpdateData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Fm");

            migrationBuilder.UpdateData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Gm");

            migrationBuilder.UpdateData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Am");

            migrationBuilder.UpdateData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "Bm");

            migrationBuilder.UpdateData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "Db");

            migrationBuilder.UpdateData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Eb");

            migrationBuilder.UpdateData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Gb");

            migrationBuilder.InsertData(
                table: "MusicKey",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 18, "Ab" },
                    { 19, "Bb" },
                    { 20, "C#" },
                    { 21, "D#" },
                    { 22, "F#" },
                    { 23, "G#" },
                    { 24, "A#" },
                    { 25, "Am" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6f203fa2-6cb7-4ecc-9304-f2f0f19abc45", "AQAAAAEAACcQAAAAEAENgJFD6A/KXpYQjWk9S6uRQFveShJVj9YkX243nSshwX/E+6x+aWaUSGXKoevHYw==" });

            migrationBuilder.UpdateData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Db");

            migrationBuilder.UpdateData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Eb");

            migrationBuilder.UpdateData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Gb");

            migrationBuilder.UpdateData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Ab");

            migrationBuilder.UpdateData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Bb");

            migrationBuilder.UpdateData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "C#");

            migrationBuilder.UpdateData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "D#");

            migrationBuilder.UpdateData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "F#");

            migrationBuilder.UpdateData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "G#");

            migrationBuilder.UpdateData(
                table: "MusicKey",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "A#");
        }
    }
}
