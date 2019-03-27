using Microsoft.EntityFrameworkCore.Migrations;

namespace FMS.Data.Migrations
{
    public partial class AllRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ef7b2957-2aa2-4c18-852f-4dff3d95e3f5", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef7b2957-2aa2-4c18-852f-4dff3d95e3f5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "38b8e924-e5a9-4a70-aa73-41fd734e02c9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2", "b9b6aa23-5d3b-4dc4-b577-7de635460e83", "Personal", "PERSONAL" },
                    { "3", "4de659d0-7bb8-4e25-a3dd-32751860527f", "EstateOwner", "ESTATEOWNER" },
                    { "4", "c05858cf-18cb-4489-b346-981ecbd89e81", "EstateAgent", "ESTATEAGENT" },
                    { "5", "1d147c79-06cc-4550-8eaa-b8e6ab0341ea", "FlatManagment", "FLATMANAGMENT" },
                    { "6", "7dd930dc-7c0a-4ddf-81e0-c447fb73c123", "Simple", "SIMPLE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7534b171-2687-4219-8fd4-d621aa677240", 0, "3b45611e-96db-4cfc-83b3-bda1a4eea87e", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEKRKk0DKsMACTTkglOUGwPSPyudscbeDgpY0SbTFbHFq+6+MYgilKqh5lhHzqzZxKQ==", "+359359", true, "3f031974-9b29-4034-a20b-ee75709bf95c", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "7534b171-2687-4219-8fd4-d621aa677240", "1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7534b171-2687-4219-8fd4-d621aa677240", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7534b171-2687-4219-8fd4-d621aa677240");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "70eb2e6c-86b8-4974-975b-b1ed36ba1d99");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ef7b2957-2aa2-4c18-852f-4dff3d95e3f5", 0, "19b57746-a36b-43aa-aa65-98abdc25aa6b", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEJP6qmoldd0D3rum/6C+3owt/JCCauHp4jS6uDMJtReZtdt6QUZwEO02OpcmdNyKEw==", "+359359", true, "94f42495-7294-4a52-88b5-2f78fac53198", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "ef7b2957-2aa2-4c18-852f-4dff3d95e3f5", "1" });
        }
    }
}
