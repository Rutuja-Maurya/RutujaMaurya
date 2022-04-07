using Microsoft.EntityFrameworkCore;
using SupplierManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierManagementSystem.Data
{
    public class BillingDatabaseContext : DbContext
    {
        public BillingDatabaseContext(DbContextOptions<BillingDatabaseContext> options) : base(options)
        {

        }
        public DbSet<Billing> Billing { get; set; }
    }
}
