using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiPax.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sample_AspNetUsers_ApplicationUserId1",
                table: "Sample");

            migrationBuilder.DropIndex(
                name: "IX_Sample_ApplicationUserId1",
                table: "Sample");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "Sample");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Sample",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Sample_ApplicationUserId",
                table: "Sample",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sample_AspNetUsers_ApplicationUserId",
                table: "Sample",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sample_AspNetUsers_ApplicationUserId",
                table: "Sample");

            migrationBuilder.DropIndex(
                name: "IX_Sample_ApplicationUserId",
                table: "Sample");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "Sample",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "Sample",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sample_ApplicationUserId1",
                table: "Sample",
                column: "ApplicationUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Sample_AspNetUsers_ApplicationUserId1",
                table: "Sample",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
