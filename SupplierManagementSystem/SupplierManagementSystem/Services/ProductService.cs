using SupplierManagementSystem.Infra;
using SupplierManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierManagementSystem.Services
{
    public class ProductService
    {
        IProduct _service;
        public ProductService(IProduct service)
        {
            _service = service;
        }
        public List<Product> GetProduct()
        {
            return _service.GetProduct().ToList();


        }
        public Product GetProductById(int ProductID)
        {
            return _service.GetProductById(ProductID);

        }
        public void AddProduct(Product product)
        {
            _service.AddProduct(product);
        }
        public void UpdateProduct(Product product)
        {
            _service.UpdateProduct(product);
        }



        public void DeleteProduct(int ProductId)
        {

            _service.DeleteProduct(ProductId);
        }
    }
}
