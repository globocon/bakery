using BMS.Data.Models;
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
            modelBuilder.Entity<Order>().Property(o => o.IsDeleted).HasDefaultValue(false);
            modelBuilder.Entity<Order>().Property(o => o.Status).HasDefaultValue("Pending");
            // Order → Customer
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Invoice>().Property(i => i.InvoiceDate).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Invoice>().Property(o => o.IsDeleted).HasDefaultValue(false);
            // Invoice → Customer
            modelBuilder.Entity<Invoice>()
                .HasOne(i => i.Customer)
                .WithMany(c => c.Invoices)
                .HasForeignKey(i => i.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<USR_Users>().Property(o => o.IsDeleted).HasDefaultValue(false);

            modelBuilder.Entity<Customer>().Property(o => o.IsDeleted).HasDefaultValue(false);            
            
            modelBuilder.Entity<Category>().Property(o => o.IsDeleted).HasDefaultValue(false);
            modelBuilder.Entity<Category>()
                .HasOne(c => c.PreparationTeam)
                .WithMany(t => t.Categories)
                .HasForeignKey(c => c.PreparationTeamId)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<SubCategory>().Property(o => o.IsDeleted).HasDefaultValue(false);

            modelBuilder.Entity<RawMaterial>().Property(r => r.StockQuantity).HasDefaultValue(0);
            modelBuilder.Entity<RawMaterial>().Property(o => o.IsDeleted).HasDefaultValue(false);
                        
            modelBuilder.Entity<Product>().Property(o => o.IsDeleted).HasDefaultValue(false);
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<PreparationTeam>().Property(o => o.IsDeleted).HasDefaultValue(false);
            //modelBuilder.Entity<PreparationTeam>()
            //    .HasMany<Category>()
            //    .WithOne(c => c.PreparationTeam)
            //    .HasForeignKey(c => c.PreparationTeamId);

            

            BakeryDbSeeder.Seed(modelBuilder);
        }

        //public override int SaveChanges()
        //{
        //    foreach (var entry in ChangeTracker.Entries<Order>()
        //             .Where(e => e.State == EntityState.Added))
        //    {
        //        // Set OrderNumber after OrderId is generated
        //        entry.State = EntityState.Detached;
        //    }

        //    foreach (var entry in ChangeTracker.Entries<Invoice>()
        //             .Where(e => e.State == EntityState.Added))
        //    {
        //        // Set InvoiceNumber after InvoiceId is generated
        //        entry.State = EntityState.Detached;
        //    }

        //    var result = base.SaveChanges();

        //    // Now OrderId is available, update OrderNumber
        //    foreach (var order in ChangeTracker.Entries<Order>()
        //             .Where(e => e.State == EntityState.Detached))
        //    {
        //        order.Entity.OrderNumber = $"ORD-{order.Entity.OrderId:D6}-{DateTime.UtcNow.Year}";
        //        Entry(order.Entity).State = EntityState.Modified;
        //    }

        //    // Now InvoiceId is available, update InvoiceNumber
        //    foreach (var invoice in ChangeTracker.Entries<Invoice>()
        //             .Where(e => e.State == EntityState.Detached))
        //    {
        //        invoice.Entity.InvoiceNumber = $"INV-{invoice.Entity.InvoiceId:D6}-{DateTime.UtcNow.Year}";
        //        Entry(invoice.Entity).State = EntityState.Modified;
        //    }

        //    base.SaveChanges();
        //    return result;
        //}

        public DbSet<USR_Users> USR_Users { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<RawMaterial> RawMaterials { get; set; }
        public DbSet<ProductRawMaterial> ProductRawMaterials { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<PreparationTeam> PreparationTeams { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<OrderConfirmData> OrderConfirmData { get; set; }
        public DbSet<ProductRawMaterialMapType> ProductRawMaterialMapType { get; set; }
        public DbSet<UomMaster> UomMaster { get; set; }

    }
   
}
