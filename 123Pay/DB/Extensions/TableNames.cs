using _123Pay.DB.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _123Pay.DB.Extensions
{
    public static class TableNames
    {
        public static void SetTableNames(this ModelBuilder builder)
        {
            // Maintenance Tables
            builder.Entity<AppUser>().ToTable("Employees");
            builder.Entity<Role>().ToTable("Roles");
            builder.Entity<IdentityRoleClaim<int>>().ToTable("RoleClaims");
            builder.Entity<IdentityUserClaim<int>>().ToTable("UserClaims");
            builder.Entity<IdentityUserLogin<int>>().ToTable("UserLogin");
            builder.Entity<IdentityUserRole<int>>().ToTable("UserRoles");
            builder.Entity<IdentityUserToken<int>>().ToTable("UserTokens");
            builder.Entity<Customer>().ToTable("Customers");
            builder.Entity<LookUp>().ToTable("LookUps");
            builder.Entity<LookupType>().ToTable("LookupTypes");
            builder.Entity<Application>().ToTable("Applications");
        }
    }
}
