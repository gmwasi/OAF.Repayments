using System.Collections.Generic;
using System.Linq;
using Repayments.Core.Interfaces;
using Repayments.Core.ViewModels;
using Repayments.Core.Models;

namespace Repayments.Core.Services
{
    public class CustomerSummaryService : ICustomerSummaryService
    {
        private readonly ICustomerSummaryRepository _customerSummaryRepository;
        private readonly IRepository<Customer> _customerRepository;

        public CustomerSummaryService(ICustomerSummaryRepository customerSummaryRepository, IRepository<Customer> customerRepository)
        {
            _customerSummaryRepository = customerSummaryRepository;
            _customerRepository = customerRepository;
        }

        public IEnumerable<CustomerSummaryView> GetAll()
        {
            var view = new List<CustomerSummaryView>();
            var customerSummaries = _customerSummaryRepository.Get();
            foreach (var customerSummary in customerSummaries)
            {
                var summary = new CustomerSummaryView
                {
                    CustomerName = customerSummary.Customer.CustomerName,
                    SeasonName = customerSummary.Season.SeasonName,
                    TotalCredit = customerSummary.TotalCredit,
                    TotalRepaid = customerSummary.TotalRepaid,
                };
                view.Add(summary);
            }

            return view;
        }
    }
}
