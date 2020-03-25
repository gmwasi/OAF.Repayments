using System;
namespace Repayments.Core.ViewModels
{
    public class CustomerSummaryView
    {
        public string CustomerName { get; set; }
        public string SeasonName{ get; set; }
        public decimal TotalRepaid { get; set; }
        public decimal TotalCredit { get; set; }
    }
}
