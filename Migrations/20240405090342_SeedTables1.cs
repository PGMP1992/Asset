using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Asset.Migrations
{
    /// <inheritdoc />
    public partial class SeedTables1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProdId",
                table: "Assets");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "DollarRate", "Name", "ShortName" },
                values: new object[,]
                {
                    { 1, 0.10000000000000001, "Sweden", "SEK" },
                    { 2, 1.1000000000000001, "Spain", "EUR" },
                    { 3, 1.0, "USA", "USD" },
                    { 4, 0.14000000000000001, "Denmark", "DKK" },
                    { 5, 1.2, "Great Britain", "GBP" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Model", "Price", "Type" },
                values: new object[,]
                {
                    { 1, "Apple", "iBook 1.0", 1500.0, "Laptop" },
                    { 2, "Apple", "iPhone 8.0", 1000.0, "Phone" },
                    { 3, "Samsung", "Galaxy 53", 1500.0, "Phone" },
                    { 4, "Samsung", "Pad 8.0", 1000.0, "Tab" },
                    { 5, "Google", "Chrome Phone", 1500.0, "Phone" },
                    { 6, "Google", "Chrome Book", 1000.0, "Laptop" }
                });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "CountryId", "ProductId", "PurchaseDate" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, 2, new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, 3, new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, 4, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, 5, new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 2, 6, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 2, 1, new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 2, 2, new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 3, 3, new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 3, 4, new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 3, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 4, 2, new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 4, 3, new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 4, 4, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 4, 5, new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 5, 6, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 5, 1, new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 5, 2, new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 5, 3, new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 5, 4, new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);

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
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AddColumn<int>(
                name: "ProdId",
                table: "Assets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
