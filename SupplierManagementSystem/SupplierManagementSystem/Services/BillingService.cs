using SupplierManagementSystem.Infra;
using SupplierManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierManagementSystem.Services
{
    public class BillingService
    {
        IBilling _service;
        public BillingService(IBilling service)
        {
            _service = service;
        }
        //public List<Billing> GetAddress()
        //{
        //    return _service.GetAddress().ToList();


        //}
        public Billing GetBillingById(int BillingID)
        {
            return _service.GetBillingById(BillingID);

        }
        public void AddAddress(Billing billing)
        {
            _service.AddAddress(billing);
        }
        public void UpdateAddress(Billing billing)
        {
            _service.UpdateAddress(billing);
        }



        public void DeleteAddress(int SupplierId)
        {

            _service.DeleteAddress(SupplierId);
        }
    }
}
