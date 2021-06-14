using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class IdentityDataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 18, 54, 56, 354, DateTimeKind.Local).AddTicks(842),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 14, 18, 24, 12, 825, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("f27b1b87-4c47-4e18-849d-6ef168c68ad8"), "c9dccd0f-7a2a-41c7-9b2b-d02d09597f68", "Admin Role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("f27b1b87-4c47-4e18-849d-6ef168c68ad8"), new Guid("9b82c708-46fa-43ed-b71b-b2ffb02c2ff0") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("9b82c708-46fa-43ed-b71b-b2ffb02c2ff0"), 0, "6f479a3f-148f-408f-b318-b72e0eafb6ee", new DateTime(2000, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "danglegiavu@gmai.com", true, "Vu", "Dang", false, null, "danglegiavu@gmai.com", "admin", "AQAAAAEAACcQAAAAEFzQb6rGPeRLmSlxcGHaphKM8owi5PBBwP4NdX3RSmmr04bm/EmsPkJZ0AMtG1/TUw==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 14, 18, 54, 56, 365, DateTimeKind.Local).AddTicks(1895));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f27b1b87-4c47-4e18-849d-6ef168c68ad8"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f27b1b87-4c47-4e18-849d-6ef168c68ad8"), new Guid("9b82c708-46fa-43ed-b71b-b2ffb02c2ff0") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("9b82c708-46fa-43ed-b71b-b2ffb02c2ff0"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 18, 24, 12, 825, DateTimeKind.Local).AddTicks(599),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 14, 18, 54, 56, 354, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 14, 18, 24, 12, 839, DateTimeKind.Local).AddTicks(2462));
        }
    }
}
