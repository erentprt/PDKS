using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LoginTime",
                table: "LoginAndExits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 30, 0, 18, 10, 515, DateTimeKind.Utc).AddTicks(4081),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 29, 17, 15, 24, 773, DateTimeKind.Utc).AddTicks(87));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfEmployment",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 30, 0, 18, 10, 514, DateTimeKind.Utc).AddTicks(4098),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 29, 17, 15, 24, 771, DateTimeKind.Utc).AddTicks(2388));

            migrationBuilder.AddColumn<int>(
                name: "TotalWorkTime",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfEmployment", "TotalWorkTime" },
                values: new object[] { new DateTime(2023, 4, 30, 0, 18, 10, 514, DateTimeKind.Utc).AddTicks(8941), 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfEmployment", "TotalWorkTime" },
                values: new object[] { new DateTime(2023, 4, 30, 0, 18, 10, 514, DateTimeKind.Utc).AddTicks(8958), 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfEmployment", "TotalWorkTime" },
                values: new object[] { new DateTime(2023, 4, 30, 0, 18, 10, 514, DateTimeKind.Utc).AddTicks(8961), 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfEmployment", "TotalWorkTime" },
                values: new object[] { new DateTime(2023, 4, 30, 0, 18, 10, 514, DateTimeKind.Utc).AddTicks(8964), 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfEmployment", "TotalWorkTime" },
                values: new object[] { new DateTime(2023, 4, 30, 0, 18, 10, 514, DateTimeKind.Utc).AddTicks(8966), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalWorkTime",
                table: "Employees");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoginTime",
                table: "LoginAndExits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 29, 17, 15, 24, 773, DateTimeKind.Utc).AddTicks(87),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 30, 0, 18, 10, 515, DateTimeKind.Utc).AddTicks(4081));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfEmployment",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 29, 17, 15, 24, 771, DateTimeKind.Utc).AddTicks(2388),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 30, 0, 18, 10, 514, DateTimeKind.Utc).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 29, 17, 15, 24, 771, DateTimeKind.Utc).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 29, 17, 15, 24, 771, DateTimeKind.Utc).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 29, 17, 15, 24, 771, DateTimeKind.Utc).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 29, 17, 15, 24, 771, DateTimeKind.Utc).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 29, 17, 15, 24, 771, DateTimeKind.Utc).AddTicks(6742));
        }
    }
}
