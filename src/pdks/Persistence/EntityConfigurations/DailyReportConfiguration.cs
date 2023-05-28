using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class DailyReportConfiguration:IEntityTypeConfiguration<DailyReport>
{
    public void Configure(EntityTypeBuilder<DailyReport> builder)
    {
        builder.ToTable("DailyReports");
        builder.HasKey(d => d.Id);
        builder.Property(d => d.MoneyPaidToday).HasDefaultValue(0);
        builder.Property(d => d.NumberOfEmployeesInTheWorkplace).HasDefaultValue(0);
        builder.Property(d => d.NumberOfEmployeesNotAtWork).HasDefaultValue(0);
        builder.Property(d => d.TotalNumberOfEmployees).HasDefaultValue(0);
        builder.Property(d => d.Date).IsRequired();

        builder.Ignore(d => d.CreatedDate);
        builder.Ignore(d => d.UpdatedDate);


        DailyReport[] dailyReports =
        {
            new DailyReport()
            {
                Id = 1,
                TotalNumberOfEmployees = 5,
                NumberOfEmployeesInTheWorkplace = 3,
                NumberOfEmployeesNotAtWork = 2,
                MoneyPaidToday = 1000,
                Date = new DateTime(2023,05,25)
            },
            new DailyReport()
            {
                Id = 2,
                TotalNumberOfEmployees = 5,
                NumberOfEmployeesInTheWorkplace = 4,
                NumberOfEmployeesNotAtWork = 1,
                MoneyPaidToday = 1250,
                Date = new DateTime(2023,05,26)
            },
            new DailyReport()
            {
                Id = 3,
                TotalNumberOfEmployees = 5,
                NumberOfEmployeesInTheWorkplace = 0,
                NumberOfEmployeesNotAtWork = 5,
                MoneyPaidToday = 0,
                Date = new DateTime(2023,05,27)
            }
        };
        builder.HasData(dailyReports);
    }
}