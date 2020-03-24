using System.Collections.Generic;
using Repayments.Core.Models;

namespace Repayments.Core.Interfaces
{
    public interface IRepaymentRepository : IRepository<Repayment>
    {
        IEnumerable<Repayment> GetByCustomerId(int customerId);
        IEnumerable<Repayment> GetBySeasonId(int seasonId);
        Repayment GetByParentId(int id);
    }
}
