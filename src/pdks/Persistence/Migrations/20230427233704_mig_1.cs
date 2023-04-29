using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfEmployment",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 27, 23, 37, 4, 485, DateTimeKind.Utc).AddTicks(6664),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 16, 23, 36, 6, 15, DateTimeKind.Utc).AddTicks(8650));

            migrationBuilder.AddColumn<double>(
                name: "AllTimeSalary",
                table: "Employees",
                type: "float",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AllTimeSalary", "DateOfEmployment" },
                values: new object[] { 0.0, new DateTime(2023, 4, 27, 23, 37, 4, 485, DateTimeKind.Utc).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AllTimeSalary", "DateOfEmployment" },
                values: new object[] { 0.0, new DateTime(2023, 4, 27, 23, 37, 4, 485, DateTimeKind.Utc).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AllTimeSalary", "DateOfEmployment" },
                values: new object[] { 0.0, new DateTime(2023, 4, 27, 23, 37, 4, 485, DateTimeKind.Utc).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AllTimeSalary", "DateOfEmployment" },
                values: new object[] { 0.0, new DateTime(2023, 4, 27, 23, 37, 4, 485, DateTimeKind.Utc).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AllTimeSalary", "DateOfEmployment" },
                values: new object[] { 0.0, new DateTime(2023, 4, 27, 23, 37, 4, 485, DateTimeKind.Utc).AddTicks(9834) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AllTimeSalary",
                table: "Employees");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfEmployment",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 16, 23, 36, 6, 15, DateTimeKind.Utc).AddTicks(8650),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 27, 23, 37, 4, 485, DateTimeKind.Utc).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfEmployment",
                value: new DateTime(2023, 3, 16, 23, 36, 6, 16, DateTimeKind.Utc).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfEmployment",
                value: new DateTime(2023, 3, 16, 23, 36, 6, 16, DateTimeKind.Utc).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfEmployment",
                value: new DateTime(2023, 3, 16, 23, 36, 6, 16, DateTimeKind.Utc).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfEmployment",
                value: new DateTime(2023, 3, 16, 23, 36, 6, 16, DateTimeKind.Utc).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfEmployment",
                value: new DateTime(2023, 3, 16, 23, 36, 6, 16, DateTimeKind.Utc).AddTicks(2312));
        }
    }
}
