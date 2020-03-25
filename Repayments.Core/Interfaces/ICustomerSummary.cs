using System.Collections.Generic;
using Repayments.Core.ViewModels;

namespace Repayments.Core.Interfaces
{
    public interface ICustomerSummaryService
    {
        IEnumerable<CustomerSummaryView> GetAll();
    }
}
