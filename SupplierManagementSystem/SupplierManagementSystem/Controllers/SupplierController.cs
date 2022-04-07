using Microsoft.AspNetCore.Authorization;
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
    public class SupplierController : Controller
    {
        SupplierService _repo;
        public SupplierController(SupplierService repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("GetSuppliers")]
        public IActionResult GetSuppliers()
        {
            var supplier = _repo.GetSuppliers();
            return Ok(supplier);
        }
        [HttpGet]
        [Route("GetSupplier")]
        public IActionResult GetSupplier(int SupplierId)
        {

            var sup = _repo.GetSupplier(SupplierId);
            return Ok(sup);
        }


        [HttpPost]
        [Route("AddSupplier")]
        public IActionResult AddSupplier([FromBody] Supplier supplier)
        {
            {
                try
                {
                    if (!ModelState.IsValid)
                    {
                        return BadRequest();
                    }
                    _repo.AddSupplier(supplier);
                    return Ok();
                }
                catch (Exception ex)
                {
                    return NotFound(ex.Message);
                }
            }

        }

        [HttpPut]
        [Route("UpdateSupplier")]
        public IActionResult UpdateSupplier(Supplier supplier)
        {
            {
                try
                {
                    if (!ModelState.IsValid)
                    {
                        return BadRequest();
                    }
                    _repo.UpdateSupplier(supplier);
                    return Ok();
                }
                catch (Exception ex)
                {
                    return NotFound(ex.Message);
                }
            }
        }
        [HttpDelete]
        [Route("DeleteSupplier")]
        public IActionResult DeleteSupplier(int supplier)
        {
            {
                try
                {
                    if (!ModelState.IsValid)
                    {
                        return BadRequest();
                    }
                    _repo.DeleteSupplier(supplier);
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




