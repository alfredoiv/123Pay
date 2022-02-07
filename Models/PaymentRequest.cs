using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _123Pay.Models
{
    public class PaymentRequest
    {
        [Key]
        public int Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ClientName { get; set; }
        public string CustomerName { get; set; }
        public string ReferenceNo { get; set; }
        public string Merchant { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public string OtherDetails { get; set; }
        public double Amount { get; set; }
        public string Status { get; set; }
        public string AttachmentFilePath { get; set; }

        public string ProcessorId { get; set; }
        public virtual ApplicationUser Processor { get; set; }

    }
}
