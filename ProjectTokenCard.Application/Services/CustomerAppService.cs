using AutoMapper;
using ProjectTokenCard.Domain.Builder;
using ProjectTokenCard.Domain.Interfaces.Services;
using ProjectTokenCard.Domain.Model;
using ProjectTokenCard.Dto;
using ProjectTokenCard.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTokenCard.Services
{
    public class CustomerAppService : ICustomerAppService
    {
        private readonly ICustomerService _service;
        private readonly IMapper _mapper;
        public CustomerAppService(ICustomerService CustomerService, IMapper mapper)
        {
            _service = CustomerService;
            _mapper = mapper;
        }

        public CustomerDto GetCustomer(CustomerDto customerDto)
        {
            CardBuilder cardBuilder = new CardBuilder();
            cardBuilder.WithCcv(customerDto.Card.Ccv);
            cardBuilder.WithNumber(customerDto.Card.Number);
           
            CustomerBuilder customerBuilder = new CustomerBuilder();
            customerBuilder.WithName(customerDto.Nome);
            customerBuilder.WithCard(cardBuilder.Instance);
            return (_mapper.Map<CustomerDto>(_service.AddCustomer(customerBuilder.Instance)));
        }

        public bool ValidateToken(CustomerDto customerDto)
        {
            return (_service.ValidateToken(_mapper.Map<Customer>(customerDto)));
        }
    }
}
