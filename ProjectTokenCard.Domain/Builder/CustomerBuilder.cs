using ProjectTokenCard.Domain.Model;
using ProjectTokenCard.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTokenCard.Domain.Builder
{
    public class CustomerBuilder
    {
        public Customer Instance = new Customer();
        public CustomerBuilder()
        {
        }

        public CustomerBuilder WithCard(Card card)
        {
            if (card == null)
                throw new InvalidOperationException("Customer must to have a card");
            Instance.Card = card;
            return this;
        }

        public CustomerBuilder WithName(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new InvalidOperationException("Customer must to be name");
            Instance.Name = name;
            return this;
        }
    }
}
