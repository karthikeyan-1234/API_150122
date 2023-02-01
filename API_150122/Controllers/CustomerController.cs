using API_150122.Models.DTOs;
using API_150122.Services;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System.Data;

namespace API_150122.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "JWTBearer", Roles = "User")]
    public class CustomerController : ControllerBase
    {
        ICustomerService service;

        public CustomerController(ICustomerService service)
        {
            this.service = service;
        }

        [HttpPost("AddCustomer",Name = "AddCustomer")]
        public async Task<IActionResult> AddCustomer(CustomerDTO newCus)
        {
            var customer = await service.AddNewCustomer(newCus);
            return CreatedAtRoute("GetCustomerById", new {id = customer.id}, customer);
        }

        [AllowAnonymous]
        [HttpGet("GetCustomerById",Name = "GetCustomerById")]
        public async Task<IActionResult> GetCustomerByID(int id)
        {
            var customer = await service.GetCustomerByID(id);

            if (customer is not null)
                return Ok(customer);

            return NotFound();
        }

        [HttpDelete("DeleteCustomerById",Name = "DeleteCustomerById")]
        public async Task<IActionResult> DeleteCustomerById(int id)
        {
            var result = await service.DeleteCustomerByID(id);

            if(result is true)
                return Ok(result);

            return BadRequest();
        }

        [HttpPut("UpdateCustomer",Name = "UpdateCustomer")]
        public async Task<IActionResult> UpdateCustomer(CustomerDTO customer)
        {
            var result = await service.UpdateCustomer(customer);

            if (result is not null)
                return Ok(result);

            return BadRequest();
        }
    }
}
