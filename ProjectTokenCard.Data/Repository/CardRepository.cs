using ProjectTokenCard.Data.Context;
using ProjectTokenCard.Domain.Interfaces.Repositories;
using ProjectTokenCard.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectTokenCard.Data.Repository
{
    public class CardRepository : RepositoryBase<Card>, ICardRepository
    {
        public CardRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public Card GetById(Guid id)
        {
            return Db.Set<Card>().FirstOrDefault(x => x.CardId == id);
        }
    }
}
