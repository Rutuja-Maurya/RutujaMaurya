using SupplierManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierManagementSystem.Infra
{
    public interface IProduct
    {
        public List<Product> GetProduct();
        public Product GetProductById(int ProductId);
        public void AddProduct(Product product);
        public void UpdateProduct(Product product);
        public void DeleteProduct(int product);
    }
}
