using System.Linq;
using Repayments.Core.Models;
using Repayments.Core.Interfaces;
using System.Collections.Generic;

namespace Repayments.Core.Services
{
    public class RepaymentService : IRepaymentService
    {
        private readonly IRepository<Season> _seasonRepository;
        private readonly IRepaymentRepository _repaymentRepository;
        private readonly ICustomerSummaryRepository _customerSummaryRepository;

        public RepaymentService(IRepository<Season> seasonRepository,
            IRepaymentRepository repaymentRepository, ICustomerSummaryRepository customerSummaryRepository)
        {
            _seasonRepository = seasonRepository;
            _repaymentRepository = repaymentRepository;
            _customerSummaryRepository = customerSummaryRepository;

        }

        public IEnumerable<Repayment> submitPayment(RepaymentUpload repaymentUpload)
        {
            return ProcessRepayment(repaymentUpload);
        }

        public IEnumerable<Repayment> submitPaymentList(IEnumerable<RepaymentUpload> repaymentUploads)
        {
            var repayments = new List<Repayment>();
            foreach (var upload in repaymentUploads)
            {
                var payments = ProcessRepayment(upload);
                repayments.AddRange(payments);
            }

            return repayments;
            
        }

        private List<Repayment> ProcessRepayment(RepaymentUpload upload)
        {
            decimal balance = upload.Amount;
            int lastParentId = 0;
            var repayments = new List<Repayment>();

            // The Overide - Handle specified season
            var a = upload.SeasonId.Equals(0);
            if (!upload.SeasonId.Equals(null) && !upload.SeasonId.Equals(0))
            {
                //create repayment record
                var payment = CreateRepaymentRecord(upload, upload.Amount, 0);
                repayments.Add(payment);
                //update customer summary
                UpdateCustomerSummary(upload.CustomerId, (int)upload.SeasonId, upload.Amount);
            }
            else
            {
                //get customer summary with outstanding repayments
                var customerSummaries = _customerSummaryRepository.GetByCustomerId(upload.CustomerId).Where(s => s.TotalCredit > s.TotalRepaid)
                    .OrderBy(o => o.SeasonId).ToList();

                //Cascade the payments while balance > 0
                foreach(var customerSummary in customerSummaries)
                {
                    //Check amount owed
                    var amountOwed = CheckAmountOwed(upload.CustomerId, customerSummary.SeasonId);

                    //create repayment record
                    var payment = CreateRepaymentRecord(upload, balance, lastParentId);
                    repayments.Add(payment);
                    lastParentId = payment.Id;

                    //deduction record if exists
                    if (balance > amountOwed)
                    {
                        // deduction record
                        decimal deduction = amountOwed - balance;
                        var deductionRecord = CreateRepaymentRecord(upload, deduction, lastParentId);
                        lastParentId = deductionRecord.Id;

                        //update customer summary
                        UpdateCustomerSummary(upload.CustomerId, customerSummary.SeasonId, amountOwed);
                    }
                    else
                    {
                        //update customer summary
                        UpdateCustomerSummary(upload.CustomerId, customerSummary.SeasonId, balance);
                    }
                    balance -= amountOwed;
                    if(balance < 0)
                    {
                        break;
                    }
                }
                // The overpaid
                if(balance > 0)
                {
                    //get latest season
                    var seasons = _seasonRepository.GetAll().OrderBy(o => o.Id).ToList();
                    var season = seasons.OrderByDescending(i => i.Id).FirstOrDefault();
                    //update customer summary
                    UpdateCustomerSummary(upload.CustomerId, season.Id, balance);
                }
            }

            return repayments;
        }

        private decimal CheckAmountOwed(int customerId, int seasonId)
        {
            var customerSummary = _customerSummaryRepository.GetByCustomerAndSeason(customerId, seasonId);
            decimal amountOwed = customerSummary.TotalCredit - customerSummary.TotalRepaid;
            return amountOwed;
        }

        private Repayment CreateRepaymentRecord(RepaymentUpload repayment, decimal amount, int parentId)
        {
            var record = new Repayment
            {
                CustomerId = repayment.CustomerId,
                SeasonId = (int)repayment.SeasonId,
                Date = repayment.Date,
                Amount = amount,
                ParentId = parentId
            };

            _repaymentRepository.Insert(record);

            return record;
        }

        private void UpdateCustomerSummary(int customerId, int seasonId, decimal amount)
        {
            var customerSummary = _customerSummaryRepository.GetByCustomerAndSeason(customerId, seasonId);
            customerSummary.TotalRepaid += amount;
            _customerSummaryRepository.Update(customerSummary);
        }
    }
}
