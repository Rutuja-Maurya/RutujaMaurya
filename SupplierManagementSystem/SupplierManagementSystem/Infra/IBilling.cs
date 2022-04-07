using SupplierManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierManagementSystem.Infra
{
    public interface IBilling
    {
        //public List<Billing> GetAddress();
        public Billing GetBillingById(int SupplierId);
        public void AddAddress(Billing billing);
        public void UpdateAddress(Billing billing);
        public void DeleteAddress(int SupplierId);
    
    }
}



