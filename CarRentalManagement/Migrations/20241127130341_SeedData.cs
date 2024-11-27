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
                    { 1, "System", new DateTime(2024, 11, 27, 21, 3, 41, 21, DateTimeKind.Local).AddTicks(4372), new DateTime(2024, 11, 27, 21, 3, 41, 21, DateTimeKind.Local).AddTicks(4384), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 27, 21, 3, 41, 21, DateTimeKind.Local).AddTicks(4388), new DateTime(2024, 11, 27, 21, 3, 41, 21, DateTimeKind.Local).AddTicks(4388), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 27, 21, 3, 41, 21, DateTimeKind.Local).AddTicks(4580), new DateTime(2024, 11, 27, 21, 3, 41, 21, DateTimeKind.Local).AddTicks(4581), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 27, 21, 3, 41, 21, DateTimeKind.Local).AddTicks(4583), new DateTime(2024, 11, 27, 21, 3, 41, 21, DateTimeKind.Local).AddTicks(4583), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 27, 21, 3, 41, 21, DateTimeKind.Local).AddTicks(4681), new DateTime(2024, 11, 27, 21, 3, 41, 21, DateTimeKind.Local).AddTicks(4682), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 27, 21, 3, 41, 21, DateTimeKind.Local).AddTicks(4683), new DateTime(2024, 11, 27, 21, 3, 41, 21, DateTimeKind.Local).AddTicks(4684), "x5", "System" },
                    { 3, "System", new DateTime(2024, 11, 27, 21, 3, 41, 21, DateTimeKind.Local).AddTicks(4685), new DateTime(2024, 11, 27, 21, 3, 41, 21, DateTimeKind.Local).AddTicks(4686), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 27, 21, 3, 41, 21, DateTimeKind.Local).AddTicks(4687), new DateTime(2024, 11, 27, 21, 3, 41, 21, DateTimeKind.Local).AddTicks(4687), "C-HR", "System" }
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
