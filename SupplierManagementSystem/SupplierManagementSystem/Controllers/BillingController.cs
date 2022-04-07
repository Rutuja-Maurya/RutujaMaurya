using Microsoft.AspNetCore.Mvc;
using SupplierManagementSystem.Data;
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
    public class BillingController : Controller
    {

        BillingService _repo;
        public BillingController(BillingService repo)
        {
            _repo = repo;
        }
        //[HttpGet]
        //[Route("GetAddress")]
        //public IActionResult GetAddress()
        //{
        //    var add = _repo.GetAddress();
        //    return Ok(add);
        //}
        [HttpGet]
        [Route("GetBillingById")]
        public IActionResult Get(int SupplierId)
        {

            var bill = _repo.GetBillingById(SupplierId);
            return Ok(bill);
        }
        [HttpPost]
        [Route("AddAddress")]
        public IActionResult AddAddress(Billing address)
        {
            {
                try
                {
                    if (!ModelState.IsValid)
                    {
                        return BadRequest();
                    }
                    _repo.AddAddress(address);
                    return Ok();
                }
                catch (Exception ex)
                {
                    return NotFound(ex.Message);
                }
            }

        }
        [HttpPut]
        [Route("UpdateAddress")]

        public IActionResult UpdateAddress(Billing address)
        {

            {
                try
                {
                    if (!ModelState.IsValid)
                    {
                        return BadRequest();
                    }
                    _repo.UpdateAddress(address);
                    return Ok();
                }
                catch (Exception ex)
                {
                    return NotFound(ex.Message);
                }
            }
        }
        [HttpDelete]
        [Route("DeleteAddress")]
        public IActionResult DeleteAddress(int SupplierId)
        {

            {
                try
                {
                    if (!ModelState.IsValid)
                    {
                        return BadRequest();
                    }
                    _repo.DeleteAddress(SupplierId);
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







