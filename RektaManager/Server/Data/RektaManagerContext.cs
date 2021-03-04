using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RektaManager.Shared;

namespace RektaManager.Server.Data
{
    public class RektaManagerContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public RektaManagerContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Bill> Bills { get; set; }

        public DbSet<BillPayment> BillPayments { get; set; }

        public DbSet<BookedItem> BookedItems { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<ChartOfAccounts> ChartOfAccounts { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Inventory> Inventories { get; set; }

        public DbSet<InventoryCategory> InventoryCategories { get; set; }

        public DbSet<OrderSales> OrderSales { get; set; }

        public DbSet<BookingSales> BookingSales { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderedItem> OrderedItems { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<StaffShift> StaffShifts { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<OrderSales>()
                .HasOne(o => o.Order)
                .WithMany(i => i.OrderSalesInvoices)
                .HasForeignKey(o => o.OrderId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<OrderSales>()
                .HasOne(o => o.Invoice)
                .WithMany(i => i.Orders)
                .HasForeignKey(o => o.InvoiceId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<BookingSales>()
                .HasOne(b => b.Booking)
                .WithMany(b => b.BookingSalesInvoices)
                .HasForeignKey(b => b.BookingId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
