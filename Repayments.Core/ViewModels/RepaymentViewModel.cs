using System;
namespace Repayments.Core.ViewModels
{
    public class RepaymentViewModel
    {
        public string CustomerName { get; set; }
        public string SeasonName { get; set; }
        public string Date { get; set; }
        public decimal Amount { get; set; }
    }
}
