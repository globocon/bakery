using BMS.Data.Models;
using iText.Layout.Borders;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BMS.Data
{
    public class BMSDbContext : DbContext
    {
        public BMSDbContext(DbContextOptions<BMSDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>().Property(o => o.OrderDate).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Invoice>().Property(i => i.InvoiceDate).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Order>().Property(o => o.Status).HasDefaultValue("Pending");
            modelBuilder.Entity<RawMaterial>().Property(r => r.StockQuantity).HasDefaultValue(0);

            modelBuilder.Entity<Product>()
                .HasOne<Category>()
                .WithMany()
                .HasForeignKey(cp => cp.CategoryId);

            //modelBuilder.Entity<CategoryProduct>()
            //    .HasOne<Product>()
            //    .WithMany()
            //    .HasForeignKey(cp => cp.ProductId);

            //modelBuilder.Entity<PreparationTeam>()
            //    .HasOne<Category>()
            //    .WithMany()
            //    .HasForeignKey(tc => tc.TeamId);

            modelBuilder.Entity<Category>()
                .HasOne<PreparationTeam>()
                .WithMany()
                .HasForeignKey(tc => tc.TeamId);


            BakeryDbSeeder.Seed(modelBuilder);
        }

        public DbSet<USR_Users> USR_Users { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<RawMaterial> RawMaterials { get; set; }
        public DbSet<ProductRawMaterial> ProductRawMaterials { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PreparationTeam> PreparationTeams { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }

    }
   
}
