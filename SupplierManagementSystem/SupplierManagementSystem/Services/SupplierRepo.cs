using SupplierManagementSystem.Data;
using SupplierManagementSystem.Infra;
using SupplierManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierManagementSystem.Services
{
    public class SupplierRepo : ISupplier
    {
        SupplierDatabaseContext _context;
        public SupplierRepo(SupplierDatabaseContext context)
        {
            _context = context;
        }
        public List<Supplier> GetSuppliers()
        {
            //return _context.Supplier.ToList();
            var result = (from s in _context.Supplier
                          select new Supplier
                          {
                              SupplierId = s.SupplierId,
                              Suppliername = s.Suppliername,
                              Product = s.Product,
                              Billing = s.Billing
                          }).ToList();
            return result;
        }

        public Supplier GetSupplier(int SupplierId)
        {
            return _context.Supplier.FirstOrDefault(e => e.SupplierId == SupplierId);

        }
        public void AddSupplier(Supplier Supplier)

        {
            _context.Add(Supplier);
            _context.Add(Supplier);
            _context.SaveChanges();
        }
        public void UpdateSupplier(Supplier Supplier)
        {
            _context.Update(Supplier);
            _context.SaveChanges();

        }
        public void DeleteSupplier(int Supplier)
        {
            var supplier = _context.Supplier.Where(s => s.SupplierId == Supplier).FirstOrDefault();
            if (supplier != null)
            {
                _context.Remove(Supplier);
                _context.SaveChanges();
            }
        }
    }
}
