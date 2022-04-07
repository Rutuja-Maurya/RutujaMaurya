using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierManagementSystem.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Productname { get; set; }
        public double UnitPrice { get; set; }
        public virtual Supplier Supplier { get; set; }


    }
}
