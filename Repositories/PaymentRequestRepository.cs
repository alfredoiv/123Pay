using _123Pay.Models;
using _123Pay.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Data;

namespace _123Pay.Repositories
{
    public class PaymentRequestRepository : IPaymentRequestRepository
    {
        private readonly AppDbContext context;

        public PaymentRequestRepository(AppDbContext context)
        {
            this.context = context;
        }

        public PaymentRequestViewModel Add(PaymentRequestViewModel viewModel)
        {
            var parameters = new[] {
                new SqlParameter("@ClientName", SqlDbType.VarChar) { Direction = ParameterDirection.Input, Value = viewModel.ClientName },
                new SqlParameter("@CustomerName", SqlDbType.VarChar) { Direction = ParameterDirection.Input, Value = viewModel.CustomerName },
                new SqlParameter("@ReferenceNo", SqlDbType.VarChar) { Direction = ParameterDirection.InputOutput, Value = viewModel.ReferenceNo },
                new SqlParameter("@Merchant", SqlDbType.VarChar) { Direction = ParameterDirection.Input, Value = viewModel.Merchant },
                new SqlParameter("@AccountNo", SqlDbType.VarChar) { Direction = ParameterDirection.Input, Value = viewModel.AccountNo },
                new SqlParameter("@AccountName", SqlDbType.VarChar) { Direction = ParameterDirection.Input, Value = viewModel.AccountName },
                new SqlParameter("@OtherDetails", SqlDbType.VarChar) { Direction = ParameterDirection.Input, Value = viewModel.OtherDetails },
                new SqlParameter("@Amount", SqlDbType.Float) { Direction = ParameterDirection.Input, Value = viewModel.Amount }
            };

            context.Database.ExecuteSqlRaw("[dbo].[spSavePaymentRequest] @ClientName, @CustomerName, @ReferenceNo, @Merchant, @AccountNo, @AccountName, @OtherDetails, @Amount", parameters);
            return viewModel;
        }

        public void UpdateAttachmentStatus(int id, string filePath, string status, string processorId)
        {
            var parameters = new[]
            {
                new SqlParameter("@ID", SqlDbType.Int) { Direction = ParameterDirection.Input, Value = id },
                new SqlParameter("@AttachmentFilePath", SqlDbType.VarChar) { Direction = ParameterDirection.Input, Value = filePath },
                new SqlParameter("@Status", SqlDbType.VarChar) { Direction = ParameterDirection.Input, Value = status },
                new SqlParameter("@ProcessorID", SqlDbType.VarChar) { Direction = ParameterDirection.Input, Value = processorId }
            };

            context.Database.ExecuteSqlRaw("[dbo].[spUpdateAttachmentStatus] @ID, @AttachmentFilePath, @Status, @ProcessorID", parameters);
        }

        public PaymentRequest Delete(int Id)
        {
            PaymentRequest paymentRequest = context.PaymentRequests.Find(Id);
            if (paymentRequest != null)
            {
                context.PaymentRequests.Remove(paymentRequest);
                context.SaveChanges();
            }
            return paymentRequest;
        }

        public PaymentRequestAttachmentViewModel GetPaymentRequest(int Id)
        {
            var model = context.PaymentRequests.Find(Id);
            if (model.Status == Status.Pending)
            {
                model.Status = Status.Processing;
                this.Update(model);
            }

            //return new PaymentRequestViewModel()
            //{
            //    Id=model.Id,
            //    AccountName = model.AccountName,
            //    AccountNo = model.AccountNo,
            //    Amount = model.Amount,
            //    AttachmentFilePath = model.AttachmentFilePath,
            //    ClientName = model.ClientName,
            //    CreateDate = model.CreateDate,
            //    CustomerName = model.CustomerName,
            //    Merchant = model.Merchant,
            //    OtherDetails = model.OtherDetails,
            //    ProcessorName = model.Processor?.UserName,
            //    ReferenceNo = model.ReferenceNo,
            //    Status = model.Status
            //};
            return new PaymentRequestAttachmentViewModel()
            {
                Id = model.Id,
                ReferenceNo = model.ReferenceNo,
                Status = model.Status,
                AttachmentFilePath = model.AttachmentFilePath
            };
        }

        public IEnumerable<PaymentRequestViewModel> GetAllPaymentRequests()
        {
            var model = from pr in context.PaymentRequests
                        join user in context.Users on pr.ProcessorId equals user.Id into lj
                        from processor in lj.DefaultIfEmpty()
                        select new PaymentRequestViewModel
                        {
                            Id = pr.Id,
                            AccountName = pr.AccountName,
                            AccountNo = pr.AccountNo,
                            Amount = pr.Amount,
                            AttachmentFilePath = pr.AttachmentFilePath,
                            ClientName = pr.ClientName,
                            CreateDate = pr.CreateDate,
                            CustomerName = pr.CustomerName,
                            Merchant = pr.Merchant,
                            OtherDetails = pr.OtherDetails,
                            ReferenceNo = pr.ReferenceNo,
                            Status = pr.Status,
                            ProcessorName = processor.UserName
                        };

            return model;
        }

        public PaymentRequest Update(PaymentRequest paymentRequestChanges)
        {
            var paymentRequest = context.PaymentRequests.Attach(paymentRequestChanges);
            paymentRequest.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

            return paymentRequestChanges;
        }


    }
}
