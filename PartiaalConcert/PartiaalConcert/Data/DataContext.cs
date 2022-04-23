using Microsoft.EntityFrameworkCore;
using PartiaalConcert.Data.Entities;

namespace PartiaalConcert.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Entrance> Entrances { get; set; }

        public DbSet<Tickets> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Entrance>().HasIndex(e => e.Description).IsUnique();
 

        }
    }
}
