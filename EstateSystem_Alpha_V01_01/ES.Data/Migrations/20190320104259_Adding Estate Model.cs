using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ES.Data.Migrations
{
    public partial class AddingEstateModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estates",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: false),
                    Country = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<int>(nullable: false),
                    Size = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    IsPublic = table.Column<bool>(nullable: false),
                    IsRentable = table.Column<bool>(nullable: false),
                    IsSellable = table.Column<bool>(nullable: false),
                    SellingPrice = table.Column<decimal>(nullable: false),
                    RentingPrice = table.Column<decimal>(nullable: false),
                    Capacity = table.Column<int>(nullable: false),
                    Image = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estates", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estates");
        }
    }
}
