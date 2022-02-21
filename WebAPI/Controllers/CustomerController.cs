﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService; 
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _customerService.GetAll();
            if (result.Success == true)
            {
                return Ok(result);
            }
            else return BadRequest(result);
        }

        [HttpGet("getbycustomerid")]
        public IActionResult GetBYCustomerId(int id)
        {
            var result = _customerService.GetById(id);
            if (result.Success == true)
            {
                return Ok(result);
            }
            else return BadRequest(result);
        }

        [HttpPost("addcustomer")]
        public IActionResult Add(Customer customer)
        {
            var result = _customerService.Add(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deletecustomer")]
        public IActionResult Delete(Customer customer)
        {
            var result = _customerService.Delete(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("updatecustomer")]
        public IActionResult Update(Customer customer)
        {
            var result = _customerService.Update(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}