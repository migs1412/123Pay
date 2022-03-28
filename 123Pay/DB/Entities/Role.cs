using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _123Pay.DB.Entities
{
    public class Role: IdentityRole<int>
    {
        public AppUser? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public AppUser? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? Status { get; set; }
    }
}
