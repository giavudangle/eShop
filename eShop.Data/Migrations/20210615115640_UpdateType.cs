using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class UpdateType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f27b1b87-4c47-4e18-849d-6ef168c68ad8"),
                column: "ConcurrencyStamp",
                value: "ca445020-e813-4034-a4a4-25b2f1df0c34");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("9b82c708-46fa-43ed-b71b-b2ffb02c2ff0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9d17dbe9-6ccf-4422-8461-1ca9d20d580d", "AQAAAAEAACcQAAAAEOMKD9DQW0i7Eu8ymMh1l/tnhECYSJYvU71bGk5WQjXvfkLZUxMcxxS/yo47jLpCIQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 15, 17, 47, 10, 436, DateTimeKind.Local).AddTicks(5418));
        }
    }
}
