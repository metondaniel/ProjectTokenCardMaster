using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ProjetoDaniel.Dto;
using ProjetoDanielApplication.Interfaces;

namespace ProjetoDaniel.Controllers
{
    [Produces("application/json")]
    [Route("api/Pedido/")]
    [EnableCors("any")]
    public class PedidoController : Controller
    {
        private readonly IPedidoAppService _appService;
        public PedidoController(IPedidoAppService pedidoAppService)
        {
            _appService = pedidoAppService;
        }
        
        [HttpGet]
        public IActionResult Get(string nomeCliente)
        {
            return Ok(_appService.GetPedido(nomeCliente));
        }

        
        [HttpGet("{id}")]
        public ActionResult Get(Guid id)
        {
            return Ok(_appService.GetPedidoById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody]PedidoDto pedidoDto)
        {
            return Ok(_appService.SavePedido(pedidoDto));
        }

        [HttpPut]
        public ActionResult Put([FromBody]PedidoDto pedidoDto)
        {
            _appService.UpdatePedido(pedidoDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            _appService.DeletePedido(id);
            return Ok();
        }
    }
}
