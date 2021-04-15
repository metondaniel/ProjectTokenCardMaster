using ProjectTokenCard.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTokenCard.Interfaces
{
    public interface ICustomerAppService
    {
        CustomerDto GetCustomer(CustomerDto customerDto);
        bool ValidateToken(CustomerDto customerDto);
    }
}
