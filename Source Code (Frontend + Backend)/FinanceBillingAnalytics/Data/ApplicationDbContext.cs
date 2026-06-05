using FinanceBillingAnalytics.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinanceBillingAnalytics.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<AuditLog> AuditLogs { get; set; }
    }
}