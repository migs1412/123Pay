using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _123Pay.DB.Entities
{
    public class Application
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int MerchantId { get; set; }
        public int Status { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string OtherDetails { get; set; }
        public string Remarks { get; set; }
        public decimal Amount { get; set; }
        public decimal ServiceFee { get; set; }
        public string Client { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ProcessedBy { get; set; }
        public string Attachment { get; set; }
    }
}
