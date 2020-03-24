using System.Linq;
using System.Collections.Generic;
using Repayments.Core.Models;
using Repayments.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Repayments.Persistence.Repository
{
    public class CustomerSummaryRepository :Repository<CustomerSummary>, ICustomerSummaryRepository
    {
        private DbSet<CustomerSummary> entities;
        public CustomerSummaryRepository(RepaymentsContext context) : base(context)
        {
            entities = context.Set<CustomerSummary>();
        }

        public CustomerSummary GetByCustomerAndSeason(int customerId, int seasonId)
        {
            return entities.SingleOrDefault(s => s.CustomerId == customerId && s.SeasonId == seasonId);
        }

        public IEnumerable<CustomerSummary> GetByCustomerId(int customerId)
        {
            return entities.Where(s => s.CustomerId == customerId).AsEnumerable();
        }

        public IEnumerable<CustomerSummary> GetBySeasonId(int seasonId)
        {
            return entities.Where(s => s.SeasonId == seasonId).AsEnumerable();
        }
    }
}
