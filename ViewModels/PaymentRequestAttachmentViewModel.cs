using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _123Pay.ViewModels
{
    public class PaymentRequestAttachmentViewModel
    {
        public int Id { get; set; }
        public string ReferenceNo { get; set; }
        public string Status { get; set; }
        public string AttachmentFilePath { get; set; }
        public IFormFile Attachment;
    }
}
