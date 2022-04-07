using SupplierManagementSystem.Infra;
using SupplierManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierManagementSystem.Services
{
    public class SupplierService
    {
        ISupplier _service;
        public SupplierService(ISupplier service)
        {
            _service = service;
        }
        public List<Supplier> GetSuppliers()
        {
            return _service.GetSuppliers().ToList();


        }
        public Supplier GetSupplier(int ID)
        {
            return _service.GetSupplier(ID);

        }
        public void AddSupplier(Supplier Supplier)
        {
            _service.AddSupplier(Supplier);
        }
        public void UpdateSupplier(Supplier Supplier)
        {
            _service.UpdateSupplier(Supplier);
        }

        //internal object GetSupplier()
        //{
        //    throw new NotImplementedException();
        //}

        public void DeleteSupplier(int SupplierId)
        {

            _service.DeleteSupplier(SupplierId);
        }
        
    }
}
