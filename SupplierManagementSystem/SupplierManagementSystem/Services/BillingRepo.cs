using SupplierManagementSystem.Data;
using SupplierManagementSystem.Infra;
using SupplierManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierManagementSystem.Services
{
    public class BillingRepo: IBilling
    {
        BillingDatabaseContext _context;
        public BillingRepo(BillingDatabaseContext context)
        {
            _context = context;
        }
      /*  public List<Billing> GetAddress()
        {
            return _context.Billing.ToList();

        }*/
        public Billing GetBillingById(int SupplierId)
        {
            return _context.Billing.FirstOrDefault(e => e.SupplierId== SupplierId);
            //return _context.Billing.ToList();
        }
        public void AddAddress(Billing billing)

        {
            _context.Add(billing);
            _context.SaveChanges();
        }
        public void UpdateAddress(Billing billing)
        {
            _context.Update(billing);
            _context.SaveChanges();

        }
        public void DeleteAddress(int SupplierId)
        {
            var billing = _context.Billing.Where(s => s.SupplierId == SupplierId).FirstOrDefault();
            if (billing != null)
            {
                _context.Remove(billing);
                _context.SaveChanges();
            }

        }
    }
}
