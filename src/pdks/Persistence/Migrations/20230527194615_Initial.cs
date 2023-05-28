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
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

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
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyReports", x => x.Id);
                });

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
                    IdentityNumber = table.Column<string>(type: "nvarchar(22)", maxLength: 22, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    HomeAddress = table.Column<string>(type: "nvarchar(555)", maxLength: 555, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(99)", maxLength: 99, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    DateOfEmployment = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 27, 19, 46, 15, 217, DateTimeKind.Utc).AddTicks(7055)),
                    DateOfTermination = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TerminationReason = table.Column<string>(type: "nvarchar(99)", maxLength: 99, nullable: true),
                    TerminationDescription = table.Column<string>(type: "nvarchar(555)", maxLength: 555, nullable: true),
                    AtWork = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    HourlySalary = table.Column<double>(type: "float", nullable: true),
                    MonthlySalary = table.Column<double>(type: "float(18)", precision: 18, scale: 4, nullable: true),
                    AllTimeSalary = table.Column<double>(type: "float(18)", precision: 18, scale: 4, nullable: true, defaultValue: 0.0),
                    TotalWorkTime = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.UniqueConstraint("AK_Employees_EmployeeCode", x => x.EmployeeCode);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LoginAndExits",
                columns: table => new
                {
                    UseridDate = table.Column<string>(name: "Userid_Date", type: "nvarchar(450)", nullable: false),
                    EmployeeCode = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    LoginTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 27, 19, 46, 15, 218, DateTimeKind.Utc).AddTicks(3913)),
                    ExitTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 27, 19, 46, 15, 218, DateTimeKind.Utc).AddTicks(4386))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginAndExits", x => x.UseridDate);
                    table.ForeignKey(
                        name: "FK_LoginAndExits_Employees_EmployeeCode",
                        column: x => x.EmployeeCode,
                        principalTable: "Employees",
                        principalColumn: "EmployeeCode");
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CreatedDate", "Email", "Password", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.com", "admin123", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin2@admin.com", "admin123", null }
                });

            migrationBuilder.InsertData(
                table: "DailyReports",
                columns: new[] { "Id", "Date", "MoneyPaidToday", "NumberOfEmployeesInTheWorkplace", "NumberOfEmployeesNotAtWork", "TotalNumberOfEmployees" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000, 3, 2, 5 },
                    { 2, new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1250, 4, 1, 5 }
                });

            migrationBuilder.InsertData(
                table: "DailyReports",
                columns: new[] { "Id", "Date", "NumberOfEmployeesNotAtWork", "TotalNumberOfEmployees" },
                values: new object[] { 3, new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5 });

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
                columns: new[] { "Id", "AllTimeSalary", "CreatedDate", "DateOfBirth", "DateOfEmployment", "DateOfTermination", "DepartmentId", "Email", "EmployeeCode", "HomeAddress", "HourlySalary", "IdentityNumber", "MonthlySalary", "Name", "PhoneNumber", "Position", "Status", "Surname", "TerminationDescription", "TerminationReason", "TotalWorkTime", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "employee1@test.com", "EMP001", "Test Address 1", 27.0, "12345678901", 8100.0, "Ali", "5555555555", "Software Developer", true, "ŞEN", null, null, 0, null },
                    { 2, 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "employee2@test.com", "EMP002", "Test Address 2", 30.0, "36525478985", 9000.0, "Veli", "5555555555", "Software Developer", true, "KANDEMİR", null, null, 0, null },
                    { 3, 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "employee3@test.com", "EMP003", "Test Address 3", 40.0, "36569874785", 12000.0, "Eren", "5555555555", "Database Designer", true, "TEPRET", null, null, 0, null },
                    { 4, 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "employee4@test.com", "EMP004", "Test Address 4", 40.0, "32125696365", 12000.0, "Mehmet", "5555555555", "Secretary", true, "ÇEVİK", null, null, 0, null },
                    { 5, 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "employee5@test.com", "EMP005", "Test Address 5", 40.0, "78996369632", 12000.0, "Hamza", "5555555555", "Secretary", true, "ERKURAN", null, null, 0, null }
                });

            migrationBuilder.InsertData(
                table: "LoginAndExits",
                columns: new[] { "Userid_Date", "EmployeeCode", "ExitTime", "LoginTime" },
                values: new object[,]
                {
                    { "1_2023-05-25", "EMP001", new DateTime(2023, 5, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1_2023-05-26", "EMP001", new DateTime(2023, 5, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "2_2023-05-25", "EMP002", new DateTime(2023, 5, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "2_2023-05-26", "EMP002", new DateTime(2023, 5, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "3_2023-05-25", "EMP003", new DateTime(2023, 5, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "3_2023-05-26", "EMP003", new DateTime(2023, 5, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "4_2023-05-26", "EMP004", new DateTime(2023, 5, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 26, 8, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Email",
                table: "Employees",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeCode",
                table: "Employees",
                column: "EmployeeCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_IdentityNumber",
                table: "Employees",
                column: "IdentityNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LoginAndExits_EmployeeCode",
                table: "LoginAndExits",
                column: "EmployeeCode");
            
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "DailyReports");

            migrationBuilder.DropTable(
                name: "LoginAndExits");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
            
            migrationBuilder.Sql($@"DROP VIEW vm_DashboardStatistics;");

        }
    }
}
