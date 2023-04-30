using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("Employees");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Name).HasMaxLength(50);
        builder.Property(e => e.Surname).HasMaxLength(50);
        
        builder.HasIndex(e => e.Email).IsUnique();
        builder.Property(e => e.Email).HasMaxLength(55);
        
        builder.Property(e => e.PhoneNumber).HasMaxLength(13);
        builder.Property(e => e.Position).HasMaxLength(99);
        builder.Property(e => e.HomeAddress).HasMaxLength(555);
        builder.Property(e => e.DateOfBirth);
        builder.Property(e => e.DateOfEmployment).HasDefaultValue(DateTime.UtcNow);
        builder.Property(e => e.DepartmentId);
        builder.Property(e => e.Status).HasDefaultValue(true);
        builder.Property(e => e.AtWork).HasDefaultValue(false);

        builder.HasIndex(e => e.EmployeeCode).IsUnique();
        builder.Property(e => e.EmployeeCode).HasMaxLength(10).IsRequired();
        
        builder.Property(e => e.HourlySalary);
        builder.Property(e => e.MonthlySalary).HasPrecision(18,4);
        builder.Property(e => e.AllTimeSalary).HasPrecision(18,4).HasDefaultValue(0.0D);
        builder.Property(e => e.DateOfTermination);
        builder.Property(e => e.TerminationReason).HasMaxLength(99);
        builder.Property(e => e.TerminationDescription).HasMaxLength(555);
        
        builder.HasIndex(e => e.IdentityNumber).IsUnique();
        builder.Property(e => e.IdentityNumber).HasMaxLength(22);


        builder.HasOne(e => e.Department)
            .WithMany(d => d.Employees)
            .HasForeignKey(e => e.DepartmentId)
            .OnDelete(DeleteBehavior.NoAction);


        Employee[] employeeSeeds =
        {
            new(
                1,
                1,
                "EMP001",
                "John",
                "Doe",
                "12345678901",
                "5555555555",
                "employee1@test.com",
                "Test Address 1",
                new DateTime(2003, 4, 22),
                "Software Developer",
                true,
                DateTime.UtcNow,
                null,
                null,
                null,
                false,
                27,
                8100,
                0,
                0),
            new(
                2,
                1,
                "EMP002",
                "Jennifer",
                "Lopez",
                "36525478985",
                "5555555555",
                "employee2@test.com",
                "Test Address 2",
                new DateTime(1990, 4, 22),
                "Software Developer",
                true,
                DateTime.UtcNow,
                null,
                null,
                null,
                false,
                30,
                9000,
                0,
                0),
            new(
                3,
                1,
                "EMP003",
                "Adriana",
                "Lima",
                "36569874785",
                "5555555555",
                "employee3@test.com",
                "Test Address 3",
                new DateTime(1990, 4, 22),
                "Database Designer",
                true,
                DateTime.UtcNow,
                null,
                null,
                null,
                false,
                40,
                12000,
                0,
                0),
            
            new(
                4,
                2,
                "EMP004",
                "Mine",
                "Tugay",
                "32125696365",
                "5555555555",
                "employee4@test.com",
                "Test Address 4",
                new DateTime(1990, 4, 22),
                "Secretary",
                true,
                DateTime.UtcNow,
                null,
                null,
                null,
                false,
                40,
                12000,
                0,
                0),
            new(
                5,
                2,
                "EMP005",
                "Burçin",
                "Terzioğlu",
                "78996369632",
                "5555555555",
                "employee5@test.com",
                "Test Address 5",
                new DateTime(1990, 4, 22),
                "Secretary",
                true,
                DateTime.UtcNow,
                null,
                null,
                null,
                false,
                40,
                12000,
                0,
                0),
            
        };
        
        builder.HasData(employeeSeeds);

    }
}