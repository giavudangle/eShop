using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class updateproducttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFeatured",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f27b1b87-4c47-4e18-849d-6ef168c68ad8"),
                column: "ConcurrencyStamp",
                value: "9819d29e-7308-4e8c-9582-76022856b61f");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("9b82c708-46fa-43ed-b71b-b2ffb02c2ff0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3610c2ff-0414-4d54-9c52-b55f3bf99fab", "AQAAAAEAACcQAAAAEMACvp3X4SHwi93NkM06/jD2GEW+OTuebCN4uasnTcqqMKHPUua4aSHkiqm1XkNr8A==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 16, 18, 12, 15, 989, DateTimeKind.Local).AddTicks(136));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFeatured",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f27b1b87-4c47-4e18-849d-6ef168c68ad8"),
                column: "ConcurrencyStamp",
                value: "11674edc-fac9-427a-a5ac-ec4de2409d42");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("9b82c708-46fa-43ed-b71b-b2ffb02c2ff0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6ab874e7-8c6a-4937-bed0-1e50ea6cb084", "AQAAAAEAACcQAAAAENgCXC7qTmmw72VuC95C66pPMIOpfERUUltMBrknxGpx6C+TlZyXdiJ6ZfJDnBOl7Q==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 15, 18, 56, 39, 812, DateTimeKind.Local).AddTicks(1439));
        }
    }
}
