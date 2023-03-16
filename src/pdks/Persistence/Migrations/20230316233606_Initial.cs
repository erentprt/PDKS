using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    EmployeeCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdentityNumbeer = table.Column<string>(type: "nvarchar(22)", maxLength: 22, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    HomeAddress = table.Column<string>(type: "nvarchar(555)", maxLength: 555, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(99)", maxLength: 99, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    DateOfEmployment = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 3, 16, 23, 36, 6, 15, DateTimeKind.Utc).AddTicks(8650)),
                    DateOfTermination = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TerminationReason = table.Column<string>(type: "nvarchar(99)", maxLength: 99, nullable: true),
                    TerminationDescription = table.Column<string>(type: "nvarchar(555)", maxLength: 555, nullable: true),
                    AtWork = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    HourlySalary = table.Column<double>(type: "float", nullable: true),
                    MonthlySalary = table.Column<double>(type: "float", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology", "IT", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources", "HR", null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedDate", "DateOfBirth", "DateOfEmployment", "DateOfTermination", "DepartmentId", "Email", "EmployeeCode", "HomeAddress", "HourlySalary", "IdentityNumbeer", "MonthlySalary", "Name", "PhoneNumber", "Position", "Status", "Surname", "TerminationDescription", "TerminationReason", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 23, 36, 6, 16, DateTimeKind.Utc).AddTicks(2288), null, 1, "employee1@test.com", "EMP001", "Test Address 1", 27.0, "12345678901", 8100.0, "John", "5555555555", "Software Developer", true, "Doe", null, null, null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 23, 36, 6, 16, DateTimeKind.Utc).AddTicks(2305), null, 1, "employee2@test.com", "EMP002", "Test Address 2", 30.0, "36525478985", 9000.0, "Jennifer", "5555555555", "Software Developer", true, "Lopez", null, null, null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 23, 36, 6, 16, DateTimeKind.Utc).AddTicks(2308), null, 1, "employee3@test.com", "EMP003", "Test Address 3", 40.0, "36569874785", 12000.0, "Adriana", "5555555555", "Database Designer", true, "Lima", null, null, null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 23, 36, 6, 16, DateTimeKind.Utc).AddTicks(2310), null, 2, "employee4@test.com", "EMP004", "Test Address 4", 40.0, "32125696365", 12000.0, "Mine", "5555555555", "Secretary", true, "Tugay", null, null, null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 23, 36, 6, 16, DateTimeKind.Utc).AddTicks(2312), null, 2, "employee5@test.com", "EMP005", "Test Address 5", 40.0, "78996369632", 12000.0, "Burçin", "5555555555", "Secretary", true, "Terzioğlu", null, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Email",
                table: "Employees",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeCode",
                table: "Employees",
                column: "EmployeeCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_IdentityNumbeer",
                table: "Employees",
                column: "IdentityNumbeer",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
