using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _123Pay.Models
{
    public class ApplicationModel
    {
        public int MerchantId  { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string OtherDetails { get; set; }
        public string Remarks { get; set; }
        public decimal Amount { get; set; }
        public decimal ServiceFee { get; set; }
        public int Status { get; set; }
        public string Client { get; set; }
    }
}
