using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ProjetoDanielApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDanielWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/TipoPizza/")]
    [EnableCors("any")]
    public class TipoPizzaController : Controller
    {
        private readonly ITipoPizzaAppSevice _appService;
        public TipoPizzaController(ITipoPizzaAppSevice pedidoAppService)
        {
            _appService = pedidoAppService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_appService.GetAll());
        }
    }
}
