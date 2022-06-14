using Microsoft.EntityFrameworkCore;
using TramSchedule.Data.Entities;

namespace TramSchedule.Data.Context
{
    public class TramScheduleContext : DbContext
    {
        public DbSet<Tram> Trams { get; set; }
        public DbSet<TramLine> TramLines { get; set; }
        public DbSet<TramStop> TramStops { get; set; }
        public DbSet<TramStopComment> TramStopsComments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server = (localdb)\mssqllocaldb; Database = TramScheduleContext; Integrated Security = True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tram>()
                        .Property(t => t.Number)
                        .IsRequired();
            modelBuilder.Entity<Tram>()
                .Property(t => t.Name)
                .HasMaxLength(100);
            modelBuilder.Entity<Tram>().HasData(
                new Tram() { Name = "tramicus", Description = "modern tram", Number = 110 },
                new Tram() { Name = "kiosk", Description = "modern tram", Number = 110 },
                new Tram() { Name = "delfin", Description = "modern tram", Number = 110 }
                );
        }
    }
}