using SupplierManagementSystem.Data;
using SupplierManagementSystem.Infra;
using SupplierManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierManagementSystem.Services
{
    public class ProductRepo: IProduct
    {
        ProductDatabaseContext _context;
        public ProductRepo(ProductDatabaseContext context)
        {
            _context = context;
        }
        public List<Product> GetProduct()
        {
            return _context.Product.ToList();

        }
        public Product GetProductById(int ProductId)
        {
            return _context.Product.FirstOrDefault(e => e.ProductId == ProductId);

        }
        public void AddProduct(Product product)

        {
            _context.Add(product);
            _context.SaveChanges();
        }
        public void UpdateProduct(Product product)
        {
            _context.Update(product);
            _context.SaveChanges();

        }
        public void DeleteProduct(int ProductId)
        {
            var product = _context.Product.Where(s => s.ProductId == ProductId).FirstOrDefault();
            if (product != null)
            {
                _context.Remove(product);
                _context.SaveChanges();
            }
            _context.Remove(product);
            _context.SaveChanges();

        }
    }
}

