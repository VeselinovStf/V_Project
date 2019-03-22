using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ES.Data.Migrations
{
    public partial class UpdatingImagesavingprocess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Estates");

            migrationBuilder.AddColumn<string>(
                name: "ImageAddres",
                table: "Estates",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageAddres",
                table: "Estates");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Estates",
                nullable: true);
        }
    }
}
