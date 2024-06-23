using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BulkyBookWeb.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 23, 13, 3, 46, 596, DateTimeKind.Local).AddTicks(4979), 1, "Action" },
                    { 2, new DateTime(2024, 6, 23, 13, 3, 46, 596, DateTimeKind.Local).AddTicks(4982), 2, "Science Fiction" },
                    { 3, new DateTime(2024, 6, 23, 13, 3, 46, 596, DateTimeKind.Local).AddTicks(4984), 3, "Romance" },
                    { 4, new DateTime(2024, 6, 23, 13, 3, 46, 596, DateTimeKind.Local).AddTicks(4987), 4, "Mystery" },
                    { 5, new DateTime(2024, 6, 23, 13, 3, 46, 596, DateTimeKind.Local).AddTicks(4989), 5, "Fantasy" },
                    { 6, new DateTime(2024, 6, 23, 13, 3, 46, 596, DateTimeKind.Local).AddTicks(4991), 6, "Horror" },
                    { 7, new DateTime(2024, 6, 23, 13, 3, 46, 596, DateTimeKind.Local).AddTicks(4993), 7, "Thriller" },
                    { 8, new DateTime(2024, 6, 23, 13, 3, 46, 596, DateTimeKind.Local).AddTicks(4995), 8, "Historical Fiction" },
                    { 9, new DateTime(2024, 6, 23, 13, 3, 46, 596, DateTimeKind.Local).AddTicks(4997), 9, "Biography" },
                    { 10, new DateTime(2024, 6, 23, 13, 3, 46, 596, DateTimeKind.Local).AddTicks(4999), 10, "Self-Help" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
