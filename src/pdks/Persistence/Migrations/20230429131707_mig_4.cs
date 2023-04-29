using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LoginTime",
                table: "LoginAndExits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 29, 13, 17, 7, 88, DateTimeKind.Utc).AddTicks(5895),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 29, 13, 15, 29, 682, DateTimeKind.Utc).AddTicks(8552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfEmployment",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 29, 13, 17, 7, 87, DateTimeKind.Utc).AddTicks(8036),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 29, 13, 15, 29, 681, DateTimeKind.Utc).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 29, 13, 17, 7, 88, DateTimeKind.Utc).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 29, 13, 17, 7, 88, DateTimeKind.Utc).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 29, 13, 17, 7, 88, DateTimeKind.Utc).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 29, 13, 17, 7, 88, DateTimeKind.Utc).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 29, 13, 17, 7, 88, DateTimeKind.Utc).AddTicks(2200));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LoginTime",
                table: "LoginAndExits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 29, 13, 15, 29, 682, DateTimeKind.Utc).AddTicks(8552),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 29, 13, 17, 7, 88, DateTimeKind.Utc).AddTicks(5895));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfEmployment",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 29, 13, 15, 29, 681, DateTimeKind.Utc).AddTicks(9471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 29, 13, 17, 7, 87, DateTimeKind.Utc).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 29, 13, 15, 29, 682, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 29, 13, 15, 29, 682, DateTimeKind.Utc).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 29, 13, 15, 29, 682, DateTimeKind.Utc).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 29, 13, 15, 29, 682, DateTimeKind.Utc).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 29, 13, 15, 29, 682, DateTimeKind.Utc).AddTicks(4310));
        }
    }
}
