using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTokenCard.Dto
{
    public class CustomerDto
    {
        public int CustomerId { get; set; }
        public string Nome { get; set; }
        public CardDto Card { get; set; }
    }
}
