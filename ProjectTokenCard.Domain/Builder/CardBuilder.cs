using ProjectTokenCard.Domain.Model;
using ProjectTokenCard.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTokenCard.Domain.Builder
{
    public class CardBuilder
    {
        public Card Instance = new Card();
        public CardBuilder()
        {
            Instance.CardId = Guid.NewGuid();
        }

        public CardBuilder WithId(Guid id)
        {
            Instance.CardId = id;
            return this;
        }

        public CardBuilder WithNumber(long cardNumber)
        {
            if (cardNumber.ToString().Length > 16)
                throw new InvalidOperationException("Card number cannot be longer than 16 characters");
            
            Instance.Number = cardNumber;
            return this;
        }

        public CardBuilder WithCcv(int ccv)
        {
            if (ccv.ToString().Length > 5)
                throw new InvalidOperationException("Card Ccv cannot be longer than 16 characters");

            Instance.Ccv = ccv;

            return this;
        }
    }
}
