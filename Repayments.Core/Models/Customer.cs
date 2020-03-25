using System.Collections.Generic;

namespace Repayments.Core.Models
{
    public class Customer : Entity 
    {
        public string CustomerName { get; set; }
        public virtual ICollection<CustomerSummary> CustomerSummaries { get; set; }
    }
}
