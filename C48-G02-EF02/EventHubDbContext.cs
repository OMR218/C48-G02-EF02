using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C48_G02_EF02.Module_Class;
using Microsoft.EntityFrameworkCore;

namespace C48_G02_EF02
{
    public class EventHubDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = EventHub; Trusted_Connection = true; TrustServerCertificate = true;");
        }

        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Badge> Badges { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EventHubDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Event>(Entity =>
            {
                Entity.HasKey(e => e.Id);

                Entity.Property(e => e.Title)
                      .IsRequired()
                      .HasMaxLength(200);

                Entity.Property(e => e.Description)
                      .IsRequired();

                Entity.Property(e => e.StartDate)
                      .IsRequired();

                Entity.Property(e => e.EndDate)
                      .IsRequired(false);

                Entity.Property(e => e.MaxAttendees)
                      .IsRequired();
            });
        }


    }
}