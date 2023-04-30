using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoginAndExits_Employees_EmployeeCode",
                table: "LoginAndExits");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoginTime",
                table: "LoginAndExits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 29, 17, 15, 24, 773, DateTimeKind.Utc).AddTicks(87),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 29, 13, 17, 7, 88, DateTimeKind.Utc).AddTicks(5895));

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeCode",
                table: "LoginAndExits",
                type: "nvarchar(10)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfEmployment",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 29, 17, 15, 24, 771, DateTimeKind.Utc).AddTicks(2388),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 29, 13, 17, 7, 87, DateTimeKind.Utc).AddTicks(8036));

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Employees_EmployeeCode",
                table: "Employees",
                column: "EmployeeCode");

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

            migrationBuilder.AddForeignKey(
                name: "FK_LoginAndExits_Employees_EmployeeCode",
                table: "LoginAndExits",
                column: "EmployeeCode",
                principalTable: "Employees",
                principalColumn: "EmployeeCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoginAndExits_Employees_EmployeeCode",
                table: "LoginAndExits");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Employees_EmployeeCode",
                table: "Employees");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoginTime",
                table: "LoginAndExits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 29, 13, 17, 7, 88, DateTimeKind.Utc).AddTicks(5895),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 29, 17, 15, 24, 773, DateTimeKind.Utc).AddTicks(87));

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeCode",
                table: "LoginAndExits",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfEmployment",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 29, 13, 17, 7, 87, DateTimeKind.Utc).AddTicks(8036),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 29, 17, 15, 24, 771, DateTimeKind.Utc).AddTicks(2388));

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

            migrationBuilder.AddForeignKey(
                name: "FK_LoginAndExits_Employees_EmployeeCode",
                table: "LoginAndExits",
                column: "EmployeeCode",
                principalTable: "Employees",
                principalColumn: "Id");
        }
    }
}
