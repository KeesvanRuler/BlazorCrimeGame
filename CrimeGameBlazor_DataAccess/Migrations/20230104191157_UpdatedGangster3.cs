using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrimeGameBlazor_DataAccess.Migrations
{
    public partial class UpdatedGangster3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gangsters_AspNetUsers_UserId",
                table: "Gangsters");

            migrationBuilder.DropIndex(
                name: "IX_Gangsters_UserId",
                table: "Gangsters");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_GangsterId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Gangsters");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Gangsters",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Gangsters_ApplicationUserId",
                table: "Gangsters",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_GangsterId",
                table: "AspNetUsers",
                column: "GangsterId",
                unique: true,
                filter: "[GangsterId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Gangsters_AspNetUsers_ApplicationUserId",
                table: "Gangsters",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gangsters_AspNetUsers_ApplicationUserId",
                table: "Gangsters");

            migrationBuilder.DropIndex(
                name: "IX_Gangsters_ApplicationUserId",
                table: "Gangsters");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_GangsterId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Gangsters");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Gangsters",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Gangsters_UserId",
                table: "Gangsters",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_GangsterId",
                table: "AspNetUsers",
                column: "GangsterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gangsters_AspNetUsers_UserId",
                table: "Gangsters",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
