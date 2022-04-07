using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierManagementSystem.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        public string Suppliername { get; set; }
        public virtual Billing Billing { get; set; }
        public virtual ICollection<Product> Product { get; set; }




    }
}
        







  
