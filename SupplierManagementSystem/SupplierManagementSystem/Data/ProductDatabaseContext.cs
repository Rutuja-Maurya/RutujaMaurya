using Microsoft.EntityFrameworkCore;
using SupplierManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierManagementSystem.Data
{
    public class ProductDatabaseContext: DbContext
    {
        public ProductDatabaseContext(DbContextOptions<ProductDatabaseContext> options) : base(options)
        {

        }
        public DbSet<Product> Product { get; set; }
    }
}
