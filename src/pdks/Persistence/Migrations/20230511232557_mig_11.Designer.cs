﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Context;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(BaseDbContext))]
    [Migration("20230511232557_mig_11")]
    partial class mig11
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.DailyReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("MoneyPaidToday")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("NumberOfEmployeesInTheWorkplace")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("NumberOfEmployeesNotAtWork")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("TotalNumberOfEmployees")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.ToTable("DailyReports", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Information Technology",
                            Name = "IT"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Human Resources",
                            Name = "HR"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double?>("AllTimeSalary")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(18, 4)
                        .HasColumnType("float(18)")
                        .HasDefaultValue(0.0);

                    b.Property<bool>("AtWork")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfEmployment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 5, 11, 23, 25, 57, 718, DateTimeKind.Utc).AddTicks(9208));

                    b.Property<DateTime?>("DateOfTermination")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DepartmentId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<string>("EmployeeCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("HomeAddress")
                        .HasMaxLength(555)
                        .HasColumnType("nvarchar(555)");

                    b.Property<double?>("HourlySalary")
                        .HasColumnType("float");

                    b.Property<string>("IdentityNumber")
                        .IsRequired()
                        .HasMaxLength(22)
                        .HasColumnType("nvarchar(22)");

                    b.Property<double?>("MonthlySalary")
                        .HasPrecision(18, 4)
                        .HasColumnType("float(18)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Position")
                        .HasMaxLength(99)
                        .HasColumnType("nvarchar(99)");

                    b.Property<bool?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TerminationDescription")
                        .HasMaxLength(555)
                        .HasColumnType("nvarchar(555)");

                    b.Property<string>("TerminationReason")
                        .HasMaxLength(99)
                        .HasColumnType("nvarchar(99)");

                    b.Property<int>("TotalWorkTime")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex("EmployeeCode")
                        .IsUnique();

                    b.HasIndex("IdentityNumber")
                        .IsUnique();

                    b.ToTable("Employees", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AllTimeSalary = 0.0,
                            AtWork = false,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(2003, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfEmployment = new DateTime(2023, 5, 11, 23, 25, 57, 719, DateTimeKind.Utc).AddTicks(3060),
                            DepartmentId = 1,
                            Email = "employee1@test.com",
                            EmployeeCode = "EMP001",
                            HomeAddress = "Test Address 1",
                            HourlySalary = 27.0,
                            IdentityNumber = "12345678901",
                            MonthlySalary = 8100.0,
                            Name = "John",
                            PhoneNumber = "5555555555",
                            Position = "Software Developer",
                            Status = true,
                            Surname = "Doe",
                            TotalWorkTime = 0
                        },
                        new
                        {
                            Id = 2,
                            AllTimeSalary = 0.0,
                            AtWork = false,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1990, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfEmployment = new DateTime(2023, 5, 11, 23, 25, 57, 719, DateTimeKind.Utc).AddTicks(3077),
                            DepartmentId = 1,
                            Email = "employee2@test.com",
                            EmployeeCode = "EMP002",
                            HomeAddress = "Test Address 2",
                            HourlySalary = 30.0,
                            IdentityNumber = "36525478985",
                            MonthlySalary = 9000.0,
                            Name = "Jennifer",
                            PhoneNumber = "5555555555",
                            Position = "Software Developer",
                            Status = true,
                            Surname = "Lopez",
                            TotalWorkTime = 0
                        },
                        new
                        {
                            Id = 3,
                            AllTimeSalary = 0.0,
                            AtWork = false,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1990, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfEmployment = new DateTime(2023, 5, 11, 23, 25, 57, 719, DateTimeKind.Utc).AddTicks(3080),
                            DepartmentId = 1,
                            Email = "employee3@test.com",
                            EmployeeCode = "EMP003",
                            HomeAddress = "Test Address 3",
                            HourlySalary = 40.0,
                            IdentityNumber = "36569874785",
                            MonthlySalary = 12000.0,
                            Name = "Adriana",
                            PhoneNumber = "5555555555",
                            Position = "Database Designer",
                            Status = true,
                            Surname = "Lima",
                            TotalWorkTime = 0
                        },
                        new
                        {
                            Id = 4,
                            AllTimeSalary = 0.0,
                            AtWork = false,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1990, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfEmployment = new DateTime(2023, 5, 11, 23, 25, 57, 719, DateTimeKind.Utc).AddTicks(3083),
                            DepartmentId = 2,
                            Email = "employee4@test.com",
                            EmployeeCode = "EMP004",
                            HomeAddress = "Test Address 4",
                            HourlySalary = 40.0,
                            IdentityNumber = "32125696365",
                            MonthlySalary = 12000.0,
                            Name = "Mine",
                            PhoneNumber = "5555555555",
                            Position = "Secretary",
                            Status = true,
                            Surname = "Tugay",
                            TotalWorkTime = 0
                        },
                        new
                        {
                            Id = 5,
                            AllTimeSalary = 0.0,
                            AtWork = false,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1990, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfEmployment = new DateTime(2023, 5, 11, 23, 25, 57, 719, DateTimeKind.Utc).AddTicks(3086),
                            DepartmentId = 2,
                            Email = "employee5@test.com",
                            EmployeeCode = "EMP005",
                            HomeAddress = "Test Address 5",
                            HourlySalary = 40.0,
                            IdentityNumber = "78996369632",
                            MonthlySalary = 12000.0,
                            Name = "Burçin",
                            PhoneNumber = "5555555555",
                            Position = "Secretary",
                            Status = true,
                            Surname = "Terzioğlu",
                            TotalWorkTime = 0
                        });
                });

            modelBuilder.Entity("Domain.Entities.LoginAndExit", b =>
                {
                    b.Property<string>("Userid_Date")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("EmployeeCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime?>("ExitTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LoginTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 5, 11, 23, 25, 57, 719, DateTimeKind.Utc).AddTicks(6888));

                    b.HasKey("Userid_Date");

                    b.HasIndex("EmployeeCode");

                    b.ToTable("LoginAndExits", (string)null);
                });

            modelBuilder.Entity("Domain.SqlViews.DashboardStatistic", b =>
                {
                    b.Property<int>("NumberOfEmployeesInTheWorkplace")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfEmployeesNotAtWork")
                        .HasColumnType("int");

                    b.Property<int>("TotalEmployees")
                        .HasColumnType("int");

                    b.Property<int>("TotalSalary")
                        .HasColumnType("int");

                    b.ToTable((string)null);

                    b.ToView("vm_DashboardStatistics", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Employee", b =>
                {
                    b.HasOne("Domain.Entities.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Domain.Entities.LoginAndExit", b =>
                {
                    b.HasOne("Domain.Entities.Employee", "Employee")
                        .WithMany("LoginAndExits")
                        .HasForeignKey("EmployeeCode")
                        .HasPrincipalKey("EmployeeCode")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Domain.Entities.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Domain.Entities.Employee", b =>
                {
                    b.Navigation("LoginAndExits");
                });
#pragma warning restore 612, 618
        }
    }
}
