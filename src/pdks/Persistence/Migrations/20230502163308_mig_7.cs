using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LoginTime",
                table: "LoginAndExits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 2, 16, 33, 7, 999, DateTimeKind.Utc).AddTicks(5383),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 30, 0, 18, 10, 515, DateTimeKind.Utc).AddTicks(4081));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfEmployment",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 2, 16, 33, 7, 998, DateTimeKind.Utc).AddTicks(7157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 30, 0, 18, 10, 514, DateTimeKind.Utc).AddTicks(4098));

            migrationBuilder.CreateTable(
                name: "DailyReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfEmployeesInTheWorkplace = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    NumberOfEmployeesNotAtWork = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    TotalNumberOfEmployees = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    MoneyPaidToday = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyReports", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfEmployment",
                value: new DateTime(2023, 5, 2, 16, 33, 7, 999, DateTimeKind.Utc).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfEmployment",
                value: new DateTime(2023, 5, 2, 16, 33, 7, 999, DateTimeKind.Utc).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfEmployment",
                value: new DateTime(2023, 5, 2, 16, 33, 7, 999, DateTimeKind.Utc).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfEmployment",
                value: new DateTime(2023, 5, 2, 16, 33, 7, 999, DateTimeKind.Utc).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfEmployment",
                value: new DateTime(2023, 5, 2, 16, 33, 7, 999, DateTimeKind.Utc).AddTicks(1302));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyReports");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoginTime",
                table: "LoginAndExits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 30, 0, 18, 10, 515, DateTimeKind.Utc).AddTicks(4081),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 2, 16, 33, 7, 999, DateTimeKind.Utc).AddTicks(5383));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfEmployment",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 30, 0, 18, 10, 514, DateTimeKind.Utc).AddTicks(4098),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 2, 16, 33, 7, 998, DateTimeKind.Utc).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 30, 0, 18, 10, 514, DateTimeKind.Utc).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 30, 0, 18, 10, 514, DateTimeKind.Utc).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 30, 0, 18, 10, 514, DateTimeKind.Utc).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 30, 0, 18, 10, 514, DateTimeKind.Utc).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfEmployment",
                value: new DateTime(2023, 4, 30, 0, 18, 10, 514, DateTimeKind.Utc).AddTicks(8966));
        }
    }
}
