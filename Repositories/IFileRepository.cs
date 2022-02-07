using _123Pay.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _123Pay.Repositories
{
    public interface IFileRepository
    {
        bool ValidateAttachment(string fileExtension);
        string ProcessUploadedFile(PaymentRequestViewModel model);
    }
}
