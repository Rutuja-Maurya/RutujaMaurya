using Microsoft.EntityFrameworkCore;
using SupplierManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierManagementSystem.Data
{
    public class SupplierDatabaseContext : DbContext
    {
        public SupplierDatabaseContext(DbContextOptions<SupplierDatabaseContext> options) : base(options)
        {

        }
        public DbSet<Supplier> Supplier { get; set; }
    }
}

