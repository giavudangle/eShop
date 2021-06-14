using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeoAlias",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 14, 17, 32, 4, 140, DateTimeKind.Local).AddTicks(52),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 10, 19, 20, 50, 596, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "Home", "Home Page" },
                    { "Keyword", "Keyword" },
                    { "Description", "Description" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsShowOnHome", "ParentId", "SortOrder", "Status" },
                values: new object[,]
                {
                    { 1, true, null, 1, 1 },
                    { 2, true, null, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "IsDefault", "Name" },
                values: new object[,]
                {
                    { "vi-VN", true, "Tiếng Việt" },
                    { "en-US", false, "English" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateCreated", "OriginalPrice", "Price" },
                values: new object[] { 1, new DateTime(2021, 6, 14, 17, 32, 4, 152, DateTimeKind.Local).AddTicks(8640), 200000m, 300000m });

            migrationBuilder.InsertData(
                table: "CategoryTranslations",
                columns: new[] { "Id", "CategoryId", "LanguageId", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, 1, "vi-VN", "Áo nam", "ao-nam", "Áo thời trang nam", "Áo nam" },
                    { 3, 2, "vi-VN", "Áo nữ", "ao-nu", "Áo thời trang nữ", "Áo nữ" },
                    { 2, 1, "en-US", "Men T-Shirt", "men-shirt", "Ment T Shirt", "Men T Shirt" },
                    { 4, 2, "en-US", "Woman T-Shirt", "woman-shirt", "Woman T Shirt", "Woman T Shirt" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "ProductTranslations",
                columns: new[] { "Id", "Description", "Details", "LanguageId", "Name", "ProductId", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, null, "Mô tả sản phẩm", "vi-VN", "Áo nam", 1, "ao-nam", "Áo nam thời trang", "Áo nam" },
                    { 2, null, "Product Description", "en-US", "Men T-Shirt", 1, "men-shirt", "Men T Shirt", "T shirt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "Description");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "Home");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "Keyword");

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "en-US");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "vi-VN");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "SeoAlias",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 10, 19, 20, 50, 596, DateTimeKind.Local).AddTicks(369),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 14, 17, 32, 4, 140, DateTimeKind.Local).AddTicks(52));
        }
    }
}
