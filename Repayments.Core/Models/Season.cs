using System;

namespace Repayments.Core.Models
{
    public class Season: Entity
    {
        public string SeasonName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
