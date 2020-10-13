using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Model
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
    }
}
