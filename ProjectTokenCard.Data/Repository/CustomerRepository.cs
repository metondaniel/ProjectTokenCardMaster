using ProjectTokenCard.Data.Context;
using ProjectTokenCard.Domain.Interfaces.Repositories;
using ProjectTokenCard.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ProjectTokenCard.Data.Repository
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(DataContext dataContext) : base(dataContext)
        {
        }
        public Customer GetById(int id)
        {
            return Db.Set<Customer>().Include(x => x.Card).Include(x=>x.Card.Token).FirstOrDefault(x => x.CustomerId == id);
        }
    }
}
