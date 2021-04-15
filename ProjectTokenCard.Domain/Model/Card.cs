using ProjectTokenCard.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTokenCard.Domain.Model
{
    public class Card
    {
        public Guid CardId { get; set; }
        public long Number { get; set; }
        public int Ccv { get; set; }
        public Token Token { get; set; }
    }
}
