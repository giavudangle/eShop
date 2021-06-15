using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 14, 18, 54, 56, 354, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 18, 54, 56, 354, DateTimeKind.Local).AddTicks(842),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f27b1b87-4c47-4e18-849d-6ef168c68ad8"),
                column: "ConcurrencyStamp",
                value: "c9dccd0f-7a2a-41c7-9b2b-d02d09597f68");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("9b82c708-46fa-43ed-b71b-b2ffb02c2ff0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6f479a3f-148f-408f-b318-b72e0eafb6ee", "AQAAAAEAACcQAAAAEFzQb6rGPeRLmSlxcGHaphKM8owi5PBBwP4NdX3RSmmr04bm/EmsPkJZ0AMtG1/TUw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 14, 18, 54, 56, 365, DateTimeKind.Local).AddTicks(1895));
        }
    }
}
