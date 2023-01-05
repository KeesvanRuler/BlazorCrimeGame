using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrimeGameBlazor_DataAccess.Migrations
{
    public partial class MadeNameOfGangsterUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Gangsters",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Gangsters_Name",
                table: "Gangsters",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Gangsters_Name",
                table: "Gangsters");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Gangsters",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
