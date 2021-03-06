﻿
namespace Repayments.Core.Models
{
    public class CustomerSummary : Entity
    {
        public int CustomerId { get; set; }
        public int SeasonId { get; set; }
        public decimal TotalRepaid { get; set; }
        public decimal TotalCredit { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Season Season { get; set; }
    }
}
