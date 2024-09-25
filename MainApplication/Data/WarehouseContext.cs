using MainApplication.Models;
using MainApplication.Models;
using Microsoft.EntityFrameworkCore;


namespace MainApplication.Data
{
    public class WarehouseContext(DbContextOptions<WarehouseContext> options) : DbContext(options)
    {
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Warehouse>()
                .HasKey(t => t.Id);

            modelBuilder.Entity<Warehouse>()
                .Property(t => t.Id)
                .ValueGeneratedOnAdd();
            
            modelBuilder.Entity<Chemical>()
                .HasKey(c => c.Id); // Define primary key for Chemical
            
            modelBuilder.Entity<Ticket>().HasKey(t => t.Id);


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