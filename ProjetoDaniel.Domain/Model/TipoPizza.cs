using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Model
{
    public class TipoPizza
    {
        public Guid Id { get; set; }

        public string Tipo { get; set; }

        public double Preco { get; set; }
    }
}
