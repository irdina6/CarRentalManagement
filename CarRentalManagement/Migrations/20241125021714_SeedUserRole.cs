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
                values: new object[] { new DateTime(2024, 11, 25, 10, 17, 13, 510, DateTimeKind.Local).AddTicks(9326), new DateTime(2024, 11, 25, 10, 17, 13, 510, DateTimeKind.Local).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 10, 17, 13, 510, DateTimeKind.Local).AddTicks(9358), new DateTime(2024, 11, 25, 10, 17, 13, 510, DateTimeKind.Local).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 10, 17, 13, 511, DateTimeKind.Local).AddTicks(75), new DateTime(2024, 11, 25, 10, 17, 13, 511, DateTimeKind.Local).AddTicks(78) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 10, 17, 13, 511, DateTimeKind.Local).AddTicks(81), new DateTime(2024, 11, 25, 10, 17, 13, 511, DateTimeKind.Local).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 10, 17, 13, 511, DateTimeKind.Local).AddTicks(294), new DateTime(2024, 11, 25, 10, 17, 13, 511, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 10, 17, 13, 511, DateTimeKind.Local).AddTicks(299), new DateTime(2024, 11, 25, 10, 17, 13, 511, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 10, 17, 13, 511, DateTimeKind.Local).AddTicks(302), new DateTime(2024, 11, 25, 10, 17, 13, 511, DateTimeKind.Local).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 10, 17, 13, 511, DateTimeKind.Local).AddTicks(306), new DateTime(2024, 11, 25, 10, 17, 13, 511, DateTimeKind.Local).AddTicks(307) });
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
                values: new object[] { new DateTime(2024, 11, 25, 10, 12, 56, 189, DateTimeKind.Local).AddTicks(8999), new DateTime(2024, 11, 25, 10, 12, 56, 189, DateTimeKind.Local).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 10, 12, 56, 189, DateTimeKind.Local).AddTicks(9022), new DateTime(2024, 11, 25, 10, 12, 56, 189, DateTimeKind.Local).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 10, 12, 56, 189, DateTimeKind.Local).AddTicks(9508), new DateTime(2024, 11, 25, 10, 12, 56, 189, DateTimeKind.Local).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 10, 12, 56, 189, DateTimeKind.Local).AddTicks(9514), new DateTime(2024, 11, 25, 10, 12, 56, 189, DateTimeKind.Local).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 10, 12, 56, 189, DateTimeKind.Local).AddTicks(9739), new DateTime(2024, 11, 25, 10, 12, 56, 189, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 10, 12, 56, 189, DateTimeKind.Local).AddTicks(9744), new DateTime(2024, 11, 25, 10, 12, 56, 189, DateTimeKind.Local).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 10, 12, 56, 189, DateTimeKind.Local).AddTicks(9748), new DateTime(2024, 11, 25, 10, 12, 56, 189, DateTimeKind.Local).AddTicks(9749) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 10, 12, 56, 189, DateTimeKind.Local).AddTicks(9752), new DateTime(2024, 11, 25, 10, 12, 56, 189, DateTimeKind.Local).AddTicks(9753) });
        }
    }
}
