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

    }
}