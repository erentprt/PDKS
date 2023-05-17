﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class LoginAndExitConfiguration:IEntityTypeConfiguration<LoginAndExit>
{
    public void Configure(EntityTypeBuilder<LoginAndExit> builder)
    {
        builder.ToTable("LoginAndExits");
        builder.HasKey(e => e.Userid_Date);
        builder.Property(e => e.Userid_Date).HasMaxLength(50);
        builder.Property(e => e.EmployeeCode).IsRequired();
        builder.Property(e => e.LoginTime).HasDefaultValue(DateTime.UtcNow);
        builder.Property(e => e.ExitTime);
        builder.Ignore(e => e.Id);
        builder.Ignore(e => e.CreatedDate);
        builder.Ignore(e => e.UpdatedDate);
        
        builder.HasOne(e => e.Employee)
            .WithMany(d => d.LoginAndExits)
            .HasForeignKey(e => e.EmployeeCode)
            .HasPrincipalKey(d => d.EmployeeCode)
            .OnDelete(DeleteBehavior.NoAction);
    }
}