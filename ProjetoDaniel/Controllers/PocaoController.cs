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
    [Route("api/Porcao/")]
    [EnableCors("any")]
    public class PocaoController : Controller
    {
        private readonly IPorcaoAppService _appService;
        public PocaoController(IPorcaoAppService pedidoAppService)
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
