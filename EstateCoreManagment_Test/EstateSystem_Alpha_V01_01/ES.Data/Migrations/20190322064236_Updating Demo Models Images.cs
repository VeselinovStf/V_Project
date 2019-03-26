using Microsoft.EntityFrameworkCore.Migrations;

namespace ES.Data.Migrations
{
    public partial class UpdatingDemoModelsImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: "ID01",
                column: "ImageAddres",
                value: "id01.jpg");

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: "ID02",
                column: "ImageAddres",
                value: "id02.jpg");

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: "ID03",
                column: "ImageAddres",
                value: "id03.jpg");

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: "ID04",
                column: "ImageAddres",
                value: "id04.jpg");

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: "ID05",
                column: "ImageAddres",
                value: "id05.jpg");

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: "ID06",
                column: "ImageAddres",
                value: "id06.jpg");

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: "ID07",
                column: "ImageAddres",
                value: "id07.jpg");

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: "ID08",
                column: "ImageAddres",
                value: "id08.jpg");

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: "ID09",
                column: "ImageAddres",
                value: "id09.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: "ID01",
                column: "ImageAddres",
                value: null);

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: "ID02",
                column: "ImageAddres",
                value: null);

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: "ID03",
                column: "ImageAddres",
                value: null);

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: "ID04",
                column: "ImageAddres",
                value: null);

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: "ID05",
                column: "ImageAddres",
                value: null);

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: "ID06",
                column: "ImageAddres",
                value: null);

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: "ID07",
                column: "ImageAddres",
                value: null);

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: "ID08",
                column: "ImageAddres",
                value: null);

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "Id",
                keyValue: "ID09",
                column: "ImageAddres",
                value: null);
        }
    }
}
