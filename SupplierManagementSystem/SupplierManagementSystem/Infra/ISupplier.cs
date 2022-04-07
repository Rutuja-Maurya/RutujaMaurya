using SupplierManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierManagementSystem.Infra
{
    public interface ISupplier
    {
        public List<Supplier> GetSuppliers();
        public Supplier GetSupplier(int SupplierId);
        public void AddSupplier(Supplier Supplier);
        public void UpdateSupplier(Supplier Supplier);
        public void DeleteSupplier(int Supplier);
        
    }
}
