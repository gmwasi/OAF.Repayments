using System;
using System.Collections.Generic;

namespace Repayments.Core.Models
{
    public class Season: Entity
    {
        public string SeasonName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual ICollection<CustomerSummary> CustomerSummaries { get; set; }
    }
}
