using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfEmployment",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 29, 13, 15, 29, 681, DateTimeKind.Utc).AddTicks(9471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 28, 10, 32, 21, 485, DateTimeKind.Utc).AddTicks(2582));

            migrationBuilder.CreateTable(
                name: "LoginAndExits",
                columns: table => new
                {
                    UseridDate = table.Column<string>(name: "Userid_Date", type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeCode = table.Column<int>(type: "int", nullable: false),
                    LoginTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 4, 29, 13, 15, 29, 682, DateTimeKind.Utc).AddTicks(8552)),
                    ExitTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginAndExits", x => x.UseridDate);
                    table.ForeignKey(
                        name: "FK_LoginAndExits_Employees_EmployeeCode",
                        column: x => x.EmployeeCode,
                        principalTable: "Employees",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LoginAndExits_EmployeeCode",
                table: "LoginAndExits",
                column: "EmployeeCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoginAndExits");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfEmployment",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 28, 10, 32, 21, 485, DateTimeKind.Utc).AddTicks(2582),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 29, 13, 15, 29, 681, DateTimeKind.Utc).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 28, 10, 32, 21, 485, DateTimeKind.Utc).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 28, 10, 32, 21, 485, DateTimeKind.Utc).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 28, 10, 32, 21, 485, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 28, 10, 32, 21, 485, DateTimeKind.Utc).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 28, 10, 32, 21, 485, DateTimeKind.Utc).AddTicks(6065));
        }
    }
}
