using System.Linq;
using System.Collections.Generic;
using Repayments.Core.Models;
using Repayments.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Repayments.Persistence.Repository
{
    public class RepaymentRepository : Repository<Repayment>, IRepaymentRepository
    {
        private DbSet<Repayment> entities;
        public RepaymentRepository(RepaymentsContext context) : base(context)
        {
            entities = context.Set<Repayment>();
        }

        public IEnumerable<Repayment> GetByCustomerId(int customerId)
        {
            return entities.Where(s => s.CustomerId == customerId).AsEnumerable();
        }

        public Repayment GetByParentId(int id)
        {
            return entities.SingleOrDefault(s => s.ParentId == id);
        }

        public IEnumerable<Repayment> GetBySeasonId(int seasonId)
        {
            return entities.Where(s => s.SeasonId == seasonId).AsEnumerable();
        }
    }
}
