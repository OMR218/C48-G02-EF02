using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C48_G02_EF02.Module_Class;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace C48_G02_EF02.Mapping_Configuration
{
    public class BadgeConfiguration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.HasKey(b => b.Id);
            
            builder.Property(b => b.BageNumber)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasIndex(b => b.BageNumber)
                   .IsUnique();

            builder.Property(b => b.IssuedDate)
                   .IsRequired();

            builder.Property(b => b.Tier)
                   .HasConversion<string>()
                   .HasMaxLength(20)
                   .IsRequired();
        }
    }
}
