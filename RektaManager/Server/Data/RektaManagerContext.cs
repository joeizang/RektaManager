using System;
using IdentityServer4.EntityFramework.Entities;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MySql.EntityFrameworkCore.Extensions;
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

        public DbSet<BookingActionsAudit> BookingAudits { get; set; }

        public DbSet<ChartOfAccounts> ChartOfAccounts { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Inventory> Inventories { get; set; }

        public DbSet<InventoryActionsAudit> InventoryAudits { get; set; }

        public DbSet<InventoryCategory> InventoryCategories { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<InvoiceActionsAudit> InvoiceAudits { get; set; }

        public DbSet<OrderSales> OrderSales { get; set; }

        public DbSet<BookingSales> BookingSales { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderActionsAudit> OrderAudits { get; set; }

        public DbSet<OrderedItem> OrderedItems { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductActionsAudit> ProductActions { get; set; }

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
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<BookingSales>()
                .HasOne(b => b.Invoice)
                .WithMany(o => o.Bookings)
                .HasForeignKey(x => x.InvoiceId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Bill>()
                .HasOne(b => b.BillPayment)
                .WithMany(b => b.Bills)
                .HasForeignKey(b => b.BillPaymentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Bill>()
                .HasOne(b => b.Supplier)
                .WithMany(s => s.SupplierBills)
                .HasForeignKey(b => b.SupplierId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Bill>()
                .HasMany(b => b.ChartOfAccounts)
                .WithMany(c => c.Bills);

            builder.Entity<Booking>()
                .HasMany(b => b.BookedItems)
                .WithOne(b => b.RequiredBooking)
                .HasForeignKey(b => b.BookingId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Booking>()
                .HasMany(b => b.BookedServices)
                .WithOne(s => s.ServiceBooking)
                .HasForeignKey(s => s.ServiceBookingId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<ChartOfAccounts>()
                .HasMany(c => c.Bills)
                .WithMany(b => b.ChartOfAccounts);

            builder.Entity<ChartOfAccounts>()
                .HasMany(c => c.Invoices)
                .WithMany(i => i.ChartOfAccounts);

            builder.Entity<Customer>()
                .HasMany(c => c.CustomerBookings)
                .WithOne(b => b.Customer)
                .HasForeignKey(b => b.CustomerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Customer>()
                .HasMany(c => c.CustomerOrders)
                .WithOne(o => o.Customer)
                .HasForeignKey(o => o.CustomerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Customer>()
                .HasMany(c => c.CustomerInvoices)
                .WithOne(i => i.Customer)
                .HasForeignKey(i => i.CustomerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Inventory>()
                .HasMany(i => i.InventoryCategories)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.Entity<Inventory>()
                .HasMany(i => i.Products)
                .WithOne(p => p.ProductInventory)
                .HasForeignKey(p => p.ProductInventoryId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Invoice>()
                .HasOne(i => i.InvoicePayment)
                .WithMany(i => i.Invoices)
                .HasForeignKey(i => i.InvoicePaymentId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Order>()
                .HasMany(o => o.OrderedItems)
                .WithOne(o => o.OwningOrder)
                .HasForeignKey(o => o.OrderId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Order>()
                .HasOne(o => o.Staff)
                .WithMany(a => a.ProcessedOrders)
                .HasForeignKey(o => o.StaffId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Product>()
                .HasMany(p => p.ProductCategories)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Service>()
                .HasOne(s => s.ServiceBooking)
                .WithMany(sb => sb.BookedServices)
                .HasForeignKey(s => s.ServiceBookingId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<StaffShift>()
                .HasOne(s => s.Staff)
                .WithMany()
                .HasForeignKey(s => s.StaffId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<DeviceFlowCodes>()
                .HasKey(x => x.UserCode);

            builder.Entity<PersistedGrant>()
                .HasKey(x => x.Key);

            builder.Entity<IdentityUserLogin<string>>()
                .HasKey(x => new {x.LoginProvider, x.ProviderKey});

            builder.Entity<IdentityUserRole<string>>()
                .HasKey(x => new {x.UserId, x.RoleId});

            builder.Entity<IdentityUserToken<string>>()
                .HasKey(x => new {x.UserId, x.LoginProvider, x.Name});

            builder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.LoginProvider).HasMaxLength(90));
            builder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.ProviderKey).HasMaxLength(90));
            
            builder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.LoginProvider).HasMaxLength(90));
            builder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.Name).HasMaxLength(90));
            
            builder.Entity<IdentityUserClaim<string>>(entity => entity.Property(m => m.Id).HasMaxLength(90));
            builder.Entity<IdentityRoleClaim<string>>(entity => entity.Property(m => m.Id).HasMaxLength(90));
            
            builder.Entity<ApplicationUser>(entity => entity.Property(m => m.Id).HasMaxLength(90));
            builder.Entity<ApplicationUser>(entity => entity.Property(m => m.CreatedAt)
                .ForMySQLHasDefaultValue(DateTimeOffset.UtcNow));
            builder.Entity<ApplicationUser>(entity => entity.Property(m => m.UpdatedAt)
                .ForMySQLHasDefaultValue(DateTimeOffset.UtcNow));
            builder.Entity<ApplicationRole>(entity => entity.Property(m => m.Id).HasMaxLength(90));
            builder.Entity<ApplicationRole>(entity => entity.Property(m => m.CreatedAt)
            .ForMySQLHasDefaultValue(DateTimeOffset.UtcNow));
            builder.Entity<ApplicationRole>(entity => entity.Property(m => m.UpdatedAt)
                .ForMySQLHasDefaultValue(DateTimeOffset.UtcNow));


        }


        public DbSet<Invoice> Invoice { get; set; }


        public DbSet<InvoicePayment> InvoicePayment { get; set; }
    }
}
