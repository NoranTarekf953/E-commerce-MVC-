using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class edit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "ProductImages",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 18, 14, 12, 31, 476, DateTimeKind.Local).AddTicks(2572), "Devices and gadgets including phones, laptops, and accessories.", "https://example.com/images/categories/electronics.jpg", "Electronics" },
                    { 2, new DateTime(2025, 10, 18, 14, 12, 31, 476, DateTimeKind.Local).AddTicks(3189), "Clothing, shoes, and accessories for all genders.", "https://example.com/images/categories/fashion.jpg", "Fashion" },
                    { 3, new DateTime(2025, 10, 18, 14, 12, 31, 476, DateTimeKind.Local).AddTicks(3198), "Wide range of educational and entertainment books.", "https://example.com/images/categories/books.jpg", "Books" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { 1, 1, "Latest Apple smartphone with advanced features.", 2000m, "iPhone 15 Pro", 45000m, 20 },
                    { 2, 2, "Stylish black leather jacket for men.", 200m, "Men’s Leather Jacket", 2500m, 50 },
                    { 3, 3, "Classic book for software developers.", 50m, "The Pragmatic Programmer", 600m, 120 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ImageId", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { 1, "https://example.com/images/products/iphone15pro-1.jpg", 1 },
                    { 2, "https://example.com/images/products/iphone15pro-2.jpg", 1 },
                    { 3, "https://example.com/images/products/leatherjacket-1.jpg", 2 },
                    { 4, "https://example.com/images/products/pragmaticprogrammer-1.jpg", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ImageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ImageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ImageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ImageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "ProductImages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()");
        }
    }
}
