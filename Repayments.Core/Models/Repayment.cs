using System;
namespace Repayments.Core.Models
{
    public class Repayment : Entity
    {
        public int CustomerId { get; set; }
        public int SeasonId { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public int ParentId { get; set; }
    }
}
