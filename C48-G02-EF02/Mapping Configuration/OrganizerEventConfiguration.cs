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
    public class OrganizerEventConfiguration : IEntityTypeConfiguration<OrganizerEvent>
    {
        public void Configure(EntityTypeBuilder<OrganizerEvent> builder)
        {
            builder.HasKey(oe => new { oe.OrganizerId, oe.EventId });

            builder.HasOne(oe => oe.organizer)
                   .WithOne(o => o.OrganizerEvent)
                   .HasForeignKey<OrganizerEvent>(oe => oe.OrganizerId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(oe => oe.Event)
                   .WithMany(e => e.OrganizerEvent)
                   .HasForeignKey(oe => oe.EventId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
