using System;
namespace Repayments.Core.Models
{
    public class RepaymentUpload
    {
        public int CustomerId { get; set; }
        public int? SeasonId { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
    }
}
