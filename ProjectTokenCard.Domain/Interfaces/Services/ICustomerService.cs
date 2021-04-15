using ProjectTokenCard.Domain.Interfaces.Services;
using ProjectTokenCard.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTokenCard.Domain.Interfaces.Services
{
    public interface ICustomerService : IServiceBase<Customer>
    {
        Customer AddCustomer(Customer customer);
        bool ValidateToken(Customer customer);
    }
}
