using ProjectTokenCard.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTokenCard.Domain.Interfaces.Repositories
{
    public interface ICardRepository : IRepositoryBase<Card>
    {
        Card GetById(Guid id);
    }
}
