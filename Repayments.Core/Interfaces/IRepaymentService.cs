using System.Collections.Generic;
using Repayments.Core.Models;

namespace Repayments.Core.Interfaces
{
    public interface IRepaymentService
    {
        IEnumerable<Repayment> submitPayment(RepaymentUpload repaymentUpload);

        IEnumerable<Repayment> submitPaymentList(IEnumerable<RepaymentUpload> repaymentUpload);
    }
}
