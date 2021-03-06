using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _123Pay.DB.Entities
{
    public class LookUp
    {
        public int Id { get; set; }
        public LookupType LookupType { get; set; }
        public int LookupTypeId { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public int Sort { get; set; }
        public int? CreatedById { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
