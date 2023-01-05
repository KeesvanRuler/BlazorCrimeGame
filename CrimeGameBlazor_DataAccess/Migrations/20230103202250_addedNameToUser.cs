using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrimeGameBlazor_DataAccess.Migrations
{
    public partial class addedNameToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Caninos_City_CityId",
                table: "Caninos");

            migrationBuilder.DropForeignKey(
                name: "FK_Caninos_Gangsters_OwnerId",
                table: "Caninos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Caninos",
                table: "Caninos");

            migrationBuilder.RenameTable(
                name: "Caninos",
                newName: "Casinos");

            migrationBuilder.RenameIndex(
                name: "IX_Caninos_OwnerId",
                table: "Casinos",
                newName: "IX_Casinos_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Caninos_CityId",
                table: "Casinos",
                newName: "IX_Casinos_CityId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InPrisonUntill",
                table: "Gangsters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Casinos",
                table: "Casinos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Casinos_City_CityId",
                table: "Casinos",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Casinos_Gangsters_OwnerId",
                table: "Casinos",
                column: "OwnerId",
                principalTable: "Gangsters",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Casinos_City_CityId",
                table: "Casinos");

            migrationBuilder.DropForeignKey(
                name: "FK_Casinos_Gangsters_OwnerId",
                table: "Casinos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Casinos",
                table: "Casinos");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "Casinos",
                newName: "Caninos");

            migrationBuilder.RenameIndex(
                name: "IX_Casinos_OwnerId",
                table: "Caninos",
                newName: "IX_Caninos_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Casinos_CityId",
                table: "Caninos",
                newName: "IX_Caninos_CityId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InPrisonUntill",
                table: "Gangsters",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Caninos",
                table: "Caninos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Caninos_City_CityId",
                table: "Caninos",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Caninos_Gangsters_OwnerId",
                table: "Caninos",
                column: "OwnerId",
                principalTable: "Gangsters",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
