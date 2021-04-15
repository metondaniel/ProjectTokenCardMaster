using ProjectTokenCard.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTokenCard.Domain.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public Card Card { get; set; }
    }
}
