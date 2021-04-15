using ProjectTokenCard.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTokenCard.Domain.Interfaces.Repositories
{
    public interface ICustomerRepository : IRepositoryBase<Customer>
    {
        Customer GetById(int id);
    }
}
