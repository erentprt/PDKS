using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"
                CREATE VIEW vm_DashboardStatistics 
                AS    
                    SELECT
                        COUNT(*) AS TotalEmployees,
                        SUM(CASE WHEN AtWork = 0 THEN 1 ELSE 0 END) AS NumberOfEmployeesNotAtWork,
                        SUM(CASE WHEN AtWork = 1 THEN 1 ELSE 0 END) AS NumberOfEmployeesInTheWorkplace,
                        SUM(COALESCE(AllTimeSalary, 0)) AS AllTimeSalary
                    FROM
                        Employees;
            ");
            migrationBuilder.AlterColumn<DateTime>(
                name: "LoginTime",
                table: "LoginAndExits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 11, 23, 25, 57, 719, DateTimeKind.Utc).AddTicks(6888),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 11, 21, 42, 34, 636, DateTimeKind.Utc).AddTicks(4361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfEmployment",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 11, 23, 25, 57, 718, DateTimeKind.Utc).AddTicks(9208),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 11, 21, 42, 34, 635, DateTimeKind.Utc).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfEmployment",
                value: new DateTime(2023, 5, 11, 23, 25, 57, 719, DateTimeKind.Utc).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfEmployment",
                value: new DateTime(2023, 5, 11, 23, 25, 57, 719, DateTimeKind.Utc).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfEmployment",
                value: new DateTime(2023, 5, 11, 23, 25, 57, 719, DateTimeKind.Utc).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfEmployment",
                value: new DateTime(2023, 5, 11, 23, 25, 57, 719, DateTimeKind.Utc).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfEmployment",
                value: new DateTime(2023, 5, 11, 23, 25, 57, 719, DateTimeKind.Utc).AddTicks(3086));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"DROP VIEW vm_DashboardStatistics;");
            migrationBuilder.AlterColumn<DateTime>(
                name: "LoginTime",
                table: "LoginAndExits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 11, 21, 42, 34, 636, DateTimeKind.Utc).AddTicks(4361),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 11, 23, 25, 57, 719, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfEmployment",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 11, 21, 42, 34, 635, DateTimeKind.Utc).AddTicks(7359),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 11, 23, 25, 57, 718, DateTimeKind.Utc).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfEmployment",
                value: new DateTime(2023, 5, 11, 21, 42, 34, 636, DateTimeKind.Utc).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfEmployment",
                value: new DateTime(2023, 5, 11, 21, 42, 34, 636, DateTimeKind.Utc).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfEmployment",
                value: new DateTime(2023, 5, 11, 21, 42, 34, 636, DateTimeKind.Utc).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfEmployment",
                value: new DateTime(2023, 5, 11, 21, 42, 34, 636, DateTimeKind.Utc).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfEmployment",
                value: new DateTime(2023, 5, 11, 21, 42, 34, 636, DateTimeKind.Utc).AddTicks(996));
        }
    }
}
