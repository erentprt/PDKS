using Domain.SqlViews;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class DashboardStatisticConfiguration: IEntityTypeConfiguration<DashboardStatistic>
{
    public void Configure(EntityTypeBuilder<DashboardStatistic> builder)
    {
        builder.ToView("vm_DashboardStatistics")
            .HasNoKey();
    }
}