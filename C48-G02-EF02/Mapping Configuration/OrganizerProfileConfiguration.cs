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
    public class OrganizerProfileConfiguration : IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(EntityTypeBuilder<OrganizerProfile> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Biography)
                   .IsRequired();

            builder.Property(p => p.Website)
                   .IsRequired(false);

            builder.Property(p => p.Logo)
                   .IsRequired(false);

            builder.HasOne(p => p.Organizer)
                   .WithOne(o => o.OrganizerProfile)
                   .HasForeignKey<OrganizerProfile>(p => p.OrganizerId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
