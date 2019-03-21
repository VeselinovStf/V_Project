using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ES.Data.Migrations
{
    public partial class AddingEstateModelDEMOINFO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Estates",
                columns: new[] { "Id", "Capacity", "City", "Country", "DeletedOn", "Description", "Image", "IsDeleted", "IsPublic", "IsRentable", "IsSellable", "ModifiedOn", "RentingPrice", "SellingPrice", "Size", "Street", "StreetAddress" },
                values: new object[,]
                {
                    { "ID01", 2, "GO", "Bulgaria", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Normal House", null, false, true, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, 100000m, 2000m, "Who knows", 66 },
                    { "ID02", 2, "GO", "Bulgaria", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Normal House", null, false, true, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, 100000m, 2000m, "Who knows", 66 },
                    { "ID03", 2, "GO", "Bulgaria", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Normal House", null, false, true, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, 100000m, 2000m, "Who knows", 66 },
                    { "ID04", 2, "GO", "Bulgaria", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Normal House", null, false, true, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, 100000m, 2000m, "Who knows", 66 },
                    { "ID05", 2, "GO", "Bulgaria", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Normal House", null, false, true, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, 100000m, 2000m, "Who knows", 66 },
                    { "ID06", 2, "GO", "Bulgaria", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Normal House", null, false, true, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, 100000m, 2000m, "Who knows", 66 },
                    { "ID07", 2, "GO", "Bulgaria", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Normal House", null, false, true, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, 100000m, 2000m, "Who knows", 66 },
                    { "ID08", 2, "GO", "Bulgaria", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Normal House", null, false, true, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, 100000m, 2000m, "Who knows", 66 },
                    { "ID09", 2, "GO", "Bulgaria", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Normal House", null, false, true, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, 100000m, 2000m, "Who knows", 66 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: "ID01");

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: "ID02");

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: "ID03");

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: "ID04");

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: "ID05");

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: "ID06");

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: "ID07");

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: "ID08");

            migrationBuilder.DeleteData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: "ID09");
        }
    }
}
