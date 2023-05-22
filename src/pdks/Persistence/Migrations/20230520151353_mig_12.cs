using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LoginTime",
                table: "LoginAndExits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 20, 15, 13, 53, 262, DateTimeKind.Utc).AddTicks(320),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 11, 23, 25, 57, 719, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "LoginAndExits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfEmployment",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 20, 15, 13, 53, 261, DateTimeKind.Utc).AddTicks(2728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 11, 23, 25, 57, 718, DateTimeKind.Utc).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfEmployment",
                value: new DateTime(2023, 5, 20, 15, 13, 53, 261, DateTimeKind.Utc).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfEmployment",
                value: new DateTime(2023, 5, 20, 15, 13, 53, 261, DateTimeKind.Utc).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfEmployment",
                value: new DateTime(2023, 5, 20, 15, 13, 53, 261, DateTimeKind.Utc).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfEmployment",
                value: new DateTime(2023, 5, 20, 15, 13, 53, 261, DateTimeKind.Utc).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfEmployment",
                value: new DateTime(2023, 5, 20, 15, 13, 53, 261, DateTimeKind.Utc).AddTicks(6798));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "LoginAndExits");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoginTime",
                table: "LoginAndExits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 11, 23, 25, 57, 719, DateTimeKind.Utc).AddTicks(6888),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 20, 15, 13, 53, 262, DateTimeKind.Utc).AddTicks(320));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfEmployment",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 11, 23, 25, 57, 718, DateTimeKind.Utc).AddTicks(9208),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 20, 15, 13, 53, 261, DateTimeKind.Utc).AddTicks(2728));

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
    }
}
