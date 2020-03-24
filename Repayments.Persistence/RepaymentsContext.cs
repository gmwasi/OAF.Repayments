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
    }
}
