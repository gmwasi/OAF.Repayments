using System;
using Microsoft.EntityFrameworkCore;
using Repayments.Core.Models;

namespace Repayments.Persistence
{
    public class RepaymentsContext : DbContext
    {
        public RepaymentsContext(DbContextOptions<RepaymentsContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Season> Seasons{ get; set; }
        public DbSet<CustomerSummary> CustomerSummaries { get; set; }
        public DbSet<Repayment> Repayments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.CustomerSummaries)
                .WithOne(e => e.Customer);

            modelBuilder.Entity<Season>()
                .HasMany(c => c.CustomerSummaries)
                .WithOne(e => e.Season);

            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Repayments)
                .WithOne(e => e.Customer);

            modelBuilder.Entity<Season>()
                .HasMany(c => c.Repayments)
                .WithOne(e => e.Season);
        }
    }
}
