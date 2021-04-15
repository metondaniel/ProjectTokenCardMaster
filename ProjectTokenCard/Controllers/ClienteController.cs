using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ProjectTokenCard.Dto;
using ProjectTokenCard.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTokenCard.Controllers
{
    [Produces("application/json")]
    [Route("api/Customer/")]
    [EnableCors("any")]
    public class ClienteController : Controller
    {
        private readonly ICustomerAppService _appService;
        public ClienteController(ICustomerAppService customerAppService)
        {
            _appService = customerAppService;
        }
        [HttpPost]
        public IActionResult Post(CustomerDto customerDto)
        {
            try
            {
                return Ok(_appService.GetCustomer(customerDto));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("validate")]
        public IActionResult Validate(CustomerDto customerDto)
        {
            try
            {
                return Ok(_appService.ValidateToken(customerDto));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
