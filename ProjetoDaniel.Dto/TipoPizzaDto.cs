using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Dto
{
    public struct TipoPizzaDto
    {
        public Guid Id { get; set; }

        public string Tipo { get; set; }

        public double Preco { get; set; }
    }
}
