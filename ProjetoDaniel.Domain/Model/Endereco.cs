using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Model
{
    public class Endereco
    {
        public Guid Id { get; set; }
        public string Logradouro { get; set; }

        public string Cep { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }
    }
}
