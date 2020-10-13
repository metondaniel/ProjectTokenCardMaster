using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Dto
{
    public class EnderecoDto
    {
        public Guid Id { get; set; }
        public string Logradouro { get; set; }

        public string Cep { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }
    }
}
