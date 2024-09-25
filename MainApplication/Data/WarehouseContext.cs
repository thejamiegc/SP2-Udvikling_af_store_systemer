using MainApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace MainApplication.Data
{
    public class WarehouseContext : DbContext
    {
        public WarehouseContext(DbContextOptions<WarehouseContext> options) : base(options) { }

        public DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Warehouse>()
                .HasKey(t => t.Id);

            modelBuilder.Entity<Warehouse>()
                .Property(t => t.Id)
                .ValueGeneratedOnAdd();
            
            modelBuilder.Entity<Chemical>()
                .HasKey(c => c.Id); // Define primary key for Chemical
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=warehouse.db");
            }
        }
    }
}