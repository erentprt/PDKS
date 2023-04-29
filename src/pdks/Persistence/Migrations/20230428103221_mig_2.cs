using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employees_Email",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "IdentityNumbeer",
                table: "Employees",
                newName: "IdentityNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_IdentityNumbeer",
                table: "Employees",
                newName: "IX_Employees_IdentityNumber");

            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "Employees",
                type: "nvarchar(99)",
                maxLength: 99,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(99)",
                oldMaxLength: 99);

            migrationBuilder.AlterColumn<double>(
                name: "MonthlySalary",
                table: "Employees",
                type: "float(18)",
                precision: 18,
                scale: 4,
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfEmployment",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 28, 10, 32, 21, 485, DateTimeKind.Utc).AddTicks(2582),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 27, 23, 37, 4, 485, DateTimeKind.Utc).AddTicks(6664));

            migrationBuilder.AlterColumn<double>(
                name: "AllTimeSalary",
                table: "Employees",
                type: "float(18)",
                precision: 18,
                scale: 4,
                nullable: true,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Email",
                table: "Employees",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employees_Email",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "IdentityNumber",
                table: "Employees",
                newName: "IdentityNumbeer");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_IdentityNumber",
                table: "Employees",
                newName: "IX_Employees_IdentityNumbeer");

            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "Employees",
                type: "nvarchar(99)",
                maxLength: 99,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(99)",
                oldMaxLength: 99,
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "MonthlySalary",
                table: "Employees",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float(18)",
                oldPrecision: 18,
                oldScale: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfEmployment",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 27, 23, 37, 4, 485, DateTimeKind.Utc).AddTicks(6664),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 28, 10, 32, 21, 485, DateTimeKind.Utc).AddTicks(2582));

            migrationBuilder.AlterColumn<double>(
                name: "AllTimeSalary",
                table: "Employees",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float(18)",
                oldPrecision: 18,
                oldScale: 4,
                oldNullable: true,
                oldDefaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 27, 23, 37, 4, 485, DateTimeKind.Utc).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 27, 23, 37, 4, 485, DateTimeKind.Utc).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 27, 23, 37, 4, 485, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 27, 23, 37, 4, 485, DateTimeKind.Utc).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 27, 23, 37, 4, 485, DateTimeKind.Utc).AddTicks(9834));

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Email",
                table: "Employees",
                column: "Email",
                unique: true);
        }
    }
}
