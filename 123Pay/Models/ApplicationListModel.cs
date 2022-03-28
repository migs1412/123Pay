using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _123Pay.Models
{
    public class ApplicationListModel
    {
        public int Id { get; set; }
        public DateTime ProcessedDate { get; set; }
        public string Client { get; set; }
        public string CustomerName { get; set; }
        public string Merchant { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string OtherDetails { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public string ProcessedBy { get; set; }
        public decimal ServiceFee { get; set; }
        public string Remarks { get; set; }
        public string Attachment { get; set; }
    }
}
