using Microsoft.AspNetCore.Mvc;
using SupplierManagementSystem.Models;
using SupplierManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        ProductService _repo;
        public ProductController(ProductService repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("GetProduct")]
        public IActionResult GetProduct()
        {
            var product = _repo.GetProduct();
            return Ok(product);
        }
        [HttpGet]
        [Route("GetProductById")]
        public IActionResult GetProductById(int ProductId)
        {

            var result = _repo.GetProductById(ProductId);
            return Ok(result);
        }
        [HttpPost]
        [Route("AddProduct")]
        public IActionResult AddProduct(Product product)
        {
            {
                try
                {
                    if (!ModelState.IsValid)
                    {
                        return BadRequest();
                    }
                    _repo.AddProduct(product);
                    return Ok();
                }
                catch (Exception ex)
                {
                    return NotFound(ex.Message);
                }
            }

        }
        [HttpPut]
        [Route("UpdateProduct")]

        public IActionResult UpdateProduct(Product product)
        {
            {
                try
                {
                    if (!ModelState.IsValid)
                    {
                        return BadRequest();
                    }
                    _repo.UpdateProduct(product);
                    return Ok();
                }
                catch (Exception ex)
                {
                    return NotFound(ex.Message);
                }
            }
        }
        [HttpDelete]
        [Route("DeletProduct")]
        public IActionResult DeleteProduct(int product)
        {
            {
                try
                {
                    if (!ModelState.IsValid)
                    {
                        return BadRequest();
                    }
                    _repo.DeleteProduct(product);
                    return Ok();
                }
                catch (Exception ex)
                {
                    return NotFound(ex.Message);
                }
            }
        }


    }
}





