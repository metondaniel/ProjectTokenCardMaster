using System;
using System.Collections.Generic;

namespace ProjetoDaniel.Dto
{
    public class PedidoDto
    {

        public DateTimeOffset Data { get; set; }

        public List<PizzaDto> Pizza { get; set; }

        public ClienteDto Cliente { get; set; }

        public double ValorTotal { get; set; }
    }
}
