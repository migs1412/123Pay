

using _123Pay.DB.Entities;
using _123Pay.DB.Extensions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _123Pay.DB
{
    public class AppDbContext : IdentityDbContext<AppUser, Role, int>
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<LookUp> LookUps { get; set; }
        public DbSet<LookupType> lookupTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
            {
                base.OnModelCreating(builder);

                builder.SetTableNames();
            }
        }
    }

