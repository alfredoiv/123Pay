using _123Pay.Models;
using _123Pay.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _123Pay.Repositories
{
    public interface IPaymentRequestRepository
    {
        PaymentRequestAttachmentViewModel GetPaymentRequest(int Id);
        PaymentRequestViewModel Add(PaymentRequestViewModel paymentRequest);
        PaymentRequest Update(PaymentRequest paymentRequest);
        PaymentRequest Delete(int Id);
        IEnumerable<PaymentRequestViewModel> GetAllPaymentRequests();
        void UpdateAttachmentStatus(int id, string filePath, string status, string processorId);
    }
}
