using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Dto
{
    public class ClienteDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public EnderecoDto Endereco { get; set; }
    }
}
