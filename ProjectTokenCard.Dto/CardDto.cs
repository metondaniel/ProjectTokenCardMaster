using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTokenCard.Dto
{
    public class CardDto
    {
        public Guid CardId { get; set; }
        public long Number { get; set; }
        public int Ccv { get; set; }
        public TokenDto Token { get; set; }
    }
}
