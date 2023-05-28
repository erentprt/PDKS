using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class LoginAndExitConfiguration : IEntityTypeConfiguration<LoginAndExit>
{
    public void Configure(EntityTypeBuilder<LoginAndExit> builder)
    {
        builder.ToTable("LoginAndExits");
        builder.HasKey(e => e.Userid_Date);
        builder.Property(e => e.Userid_Date);
        builder.Property(e => e.EmployeeCode).IsRequired();
        builder.Property(e => e.LoginTime).HasDefaultValue(DateTime.UtcNow);
        builder.Property(e => e.ExitTime);
        builder.Property(e => e.CreatedDate).HasDefaultValue(DateTime.UtcNow);
        builder.Ignore(e => e.Id);
        builder.Ignore(e => e.UpdatedDate);

        builder.HasOne(e => e.Employee)
            .WithMany(d => d.LoginAndExits)
            .HasForeignKey(e => e.EmployeeCode)
            .HasPrincipalKey(d => d.EmployeeCode)
            .OnDelete(DeleteBehavior.NoAction);

        
        
        builder.HasData(
            new {
            Id = 1,
            EmployeeCode = "EMP001",
            LoginTime = new DateTime(2023, 05, 25, 8, 0, 0),
            ExitTime = new DateTime(2023, 05, 25, 17, 0, 0),
            Userid_Date = "1_2023-05-25"
        }, 
            new {
            Id = 2,
            EmployeeCode = "EMP002",
            LoginTime = new DateTime(2023, 05, 25, 8, 0, 0),
            ExitTime = new DateTime(2023, 05, 25, 17, 0, 0),
            Userid_Date = "2_2023-05-25"
        },
            new {
            Id = 3,
            EmployeeCode = "EMP003",
            LoginTime = new DateTime(2023, 05, 25, 8, 0, 0),
            ExitTime = new DateTime(2023, 05, 25, 17, 0, 0),
            Userid_Date = "3_2023-05-25"
        }, 
            new {
            Id = 4,
            EmployeeCode = "EMP001",
            LoginTime = new DateTime(2023, 05, 26, 8, 0, 0),
            ExitTime = new DateTime(2023, 05, 26, 17, 0, 0),
            Userid_Date = "1_2023-05-26"
        }, 
            new {
            Id = 5,
            EmployeeCode = "EMP002",
            LoginTime = new DateTime(2023, 05, 26, 8, 0, 0),
            ExitTime = new DateTime(2023, 05, 26, 17, 0, 0),
            Userid_Date = "2_2023-05-26"
        }, 
            new {
            Id = 6,
            EmployeeCode = "EMP003",
            LoginTime = new DateTime(2023, 05, 26, 8, 0, 0),
            ExitTime = new DateTime(2023, 05, 26, 17, 0, 0),
            Userid_Date = "3_2023-05-26"
        }, 
            new {
            Id = 7,
            EmployeeCode = "EMP004",
            LoginTime = new DateTime(2023, 05, 26, 8, 0, 0),
            ExitTime = new DateTime(2023, 05, 26, 17, 0, 0),
            Userid_Date = "4_2023-05-26"
        });
        
        
        
    }
}