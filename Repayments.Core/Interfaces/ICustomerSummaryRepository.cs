using System.Collections.Generic;
using Repayments.Core.Models;

namespace Repayments.Core.Interfaces
{
    public interface ICustomerSummaryRepository : IRepository<CustomerSummary>
    {
        IEnumerable<CustomerSummary> GetByCustomerId(int customerId);
        IEnumerable<CustomerSummary> GetBySeasonId(int seasonId);
        CustomerSummary GetByCustomerAndSeason(int customerId, int seasonId);
        IEnumerable<CustomerSummary> Get();
    }
}
