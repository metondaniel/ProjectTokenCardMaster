using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ProjetoDaniel.Dto;
using ProjetoDanielApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDanielWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Cliente/")]
    [EnableCors("any")]
    public class ClienteController : Controller
    {
        private readonly IClienteAppService _appService;
        public ClienteController(IClienteAppService pedidoAppService)
        {
            _appService = pedidoAppService;
        }
        [HttpGet]
        public IActionResult Get(string nomeCliente)
        {
            return Ok(_appService.GetCliente(nomeCliente));
        }
    }
}
