﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
   
        IBrandService _brandService;
        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;   
        }
        [HttpGet("getall")]

        public IActionResult Get()
        {
            var result = _brandService.GetAll();
            if (result.Success == true)
            {
                return Ok(result);
            }
            else return BadRequest(result);
        }
        [HttpGet("getbybrandid")]
        public IActionResult GetByBrandId(int id)
        {
            var result = _brandService.GetBrandsByBrandId(id);
            if (result.Success == true)
            {
                return Ok(result);
            }
            else return BadRequest(result);
        }

        [HttpPost("addbrand")]
        public IActionResult Add(Brand brand)
        {
            var result = _brandService.Add(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deletebrand")]
        public IActionResult Delete(Brand brand)
        {
            var result = _brandService.Delete(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("updatebrand")]
        public IActionResult Update(Brand brand)
        {
            var result = _brandService.Update(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
