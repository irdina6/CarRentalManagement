using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 19, 45, 154, DateTimeKind.Local).AddTicks(4662), new DateTime(2024, 11, 27, 21, 19, 45, 154, DateTimeKind.Local).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 19, 45, 154, DateTimeKind.Local).AddTicks(4678), new DateTime(2024, 11, 27, 21, 19, 45, 154, DateTimeKind.Local).AddTicks(4679) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 19, 45, 154, DateTimeKind.Local).AddTicks(4927), new DateTime(2024, 11, 27, 21, 19, 45, 154, DateTimeKind.Local).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 19, 45, 154, DateTimeKind.Local).AddTicks(4930), new DateTime(2024, 11, 27, 21, 19, 45, 154, DateTimeKind.Local).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 19, 45, 154, DateTimeKind.Local).AddTicks(5028), new DateTime(2024, 11, 27, 21, 19, 45, 154, DateTimeKind.Local).AddTicks(5029) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 19, 45, 154, DateTimeKind.Local).AddTicks(5030), new DateTime(2024, 11, 27, 21, 19, 45, 154, DateTimeKind.Local).AddTicks(5031) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 19, 45, 154, DateTimeKind.Local).AddTicks(5032), new DateTime(2024, 11, 27, 21, 19, 45, 154, DateTimeKind.Local).AddTicks(5032) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 19, 45, 154, DateTimeKind.Local).AddTicks(5034), new DateTime(2024, 11, 27, 21, 19, 45, 154, DateTimeKind.Local).AddTicks(5034) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 14, 49, 752, DateTimeKind.Local).AddTicks(5868), new DateTime(2024, 11, 27, 21, 14, 49, 752, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 14, 49, 752, DateTimeKind.Local).AddTicks(5882), new DateTime(2024, 11, 27, 21, 14, 49, 752, DateTimeKind.Local).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 14, 49, 752, DateTimeKind.Local).AddTicks(6098), new DateTime(2024, 11, 27, 21, 14, 49, 752, DateTimeKind.Local).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 14, 49, 752, DateTimeKind.Local).AddTicks(6101), new DateTime(2024, 11, 27, 21, 14, 49, 752, DateTimeKind.Local).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 14, 49, 752, DateTimeKind.Local).AddTicks(6195), new DateTime(2024, 11, 27, 21, 14, 49, 752, DateTimeKind.Local).AddTicks(6196) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 14, 49, 752, DateTimeKind.Local).AddTicks(6197), new DateTime(2024, 11, 27, 21, 14, 49, 752, DateTimeKind.Local).AddTicks(6198) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 14, 49, 752, DateTimeKind.Local).AddTicks(6199), new DateTime(2024, 11, 27, 21, 14, 49, 752, DateTimeKind.Local).AddTicks(6199) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 14, 49, 752, DateTimeKind.Local).AddTicks(6200), new DateTime(2024, 11, 27, 21, 14, 49, 752, DateTimeKind.Local).AddTicks(6201) });
        }
    }
}
