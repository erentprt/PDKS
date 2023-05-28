using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class AdminEntityConfiguration : IEntityTypeConfiguration<Admin>
{
    public void Configure(EntityTypeBuilder<Admin> builder)
    {
        builder.ToTable("Admins");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Email).IsRequired();
        builder.Property(x => x.Password).IsRequired();

        Admin[] adminSeeds =
        {
            new Admin()
            {
                Id = 1,
                Email = "admin@admin.com",
                Password = "admin123"
            },
            new Admin()
            {
                Id = 2,
                Email = "admin2@admin.com",
                Password = "admin123"
            }
        };
        builder.HasData(adminSeeds);
    }
}