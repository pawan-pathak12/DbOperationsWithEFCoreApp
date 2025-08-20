using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DbOperationsWithEFCoreApp.Migrations
{
    /// <inheritdoc />
    public partial class Added_Book_BookPrices_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CreatedOn", "Description", "IsActive", "LanguageId", "NoOfPages", "Title" },
                values: new object[,]
                {
                    { 1, new DateOnly(2024, 1, 1), "A beginner's book for ASP.NET Core and EF Core.", true, 1, 350, "Learn ASP.NET Core" },
                    { 2, new DateOnly(2023, 10, 15), "Advanced guide to C# programming.", true, 1, 500, "Mastering C#" },
                    { 3, new DateOnly(2022, 5, 20), "Web design with HTML and CSS.", true, 2, 280, "HTML & CSS Design" },
                    { 4, new DateOnly(2021, 8, 10), "Learn SQL from scratch.", true, 3, 320, "Introduction to SQL" },
                    { 5, new DateOnly(2024, 3, 5), "Core concepts of JavaScript.", true, 1, 400, "JavaScript Essentials" }
                });

            migrationBuilder.InsertData(
                table: "BookPrice",
                columns: new[] { "Id", "Amount", "BookId", "CurrencyId" },
                values: new object[,]
                {
                    { 1, 29.99m, 1, 1 },
                    { 2, 39.99m, 2, 1 },
                    { 3, 19.99m, 3, 2 },
                    { 4, 24.50m, 4, 3 },
                    { 5, 34.99m, 5, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookPrice",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookPrice",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookPrice",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BookPrice",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BookPrice",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
