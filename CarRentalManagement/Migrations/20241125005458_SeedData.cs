using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 25, 8, 54, 57, 292, DateTimeKind.Local).AddTicks(3605), new DateTime(2024, 11, 25, 8, 54, 57, 292, DateTimeKind.Local).AddTicks(3629), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 25, 8, 54, 57, 292, DateTimeKind.Local).AddTicks(3635), new DateTime(2024, 11, 25, 8, 54, 57, 292, DateTimeKind.Local).AddTicks(3637), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 25, 8, 54, 57, 292, DateTimeKind.Local).AddTicks(4027), new DateTime(2024, 11, 25, 8, 54, 57, 292, DateTimeKind.Local).AddTicks(4028), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 25, 8, 54, 57, 292, DateTimeKind.Local).AddTicks(4032), new DateTime(2024, 11, 25, 8, 54, 57, 292, DateTimeKind.Local).AddTicks(4033), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 25, 8, 54, 57, 292, DateTimeKind.Local).AddTicks(4229), new DateTime(2024, 11, 25, 8, 54, 57, 292, DateTimeKind.Local).AddTicks(4231), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 25, 8, 54, 57, 292, DateTimeKind.Local).AddTicks(4234), new DateTime(2024, 11, 25, 8, 54, 57, 292, DateTimeKind.Local).AddTicks(4236), "x5", "System" },
                    { 3, "System", new DateTime(2024, 11, 25, 8, 54, 57, 292, DateTimeKind.Local).AddTicks(4238), new DateTime(2024, 11, 25, 8, 54, 57, 292, DateTimeKind.Local).AddTicks(4239), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 25, 8, 54, 57, 292, DateTimeKind.Local).AddTicks(4242), new DateTime(2024, 11, 25, 8, 54, 57, 292, DateTimeKind.Local).AddTicks(4243), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
