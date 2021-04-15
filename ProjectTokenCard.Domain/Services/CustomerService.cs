using ProjectTokenCard.Domain.Interfaces.Repositories;
using ProjectTokenCard.Domain.Interfaces.Services;
using ProjectTokenCard.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectTokenCard.Domain.Services
{
    public class CustomerService : ServiceBase<Customer>, ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ICardRepository _cardRepository;
        public CustomerService(ICustomerRepository customerRepository, ICardRepository cardRepository) : base(customerRepository)
        {
            _customerRepository = customerRepository;
            _cardRepository = cardRepository;
        }

        public Customer AddCustomer(Customer customer)
        {
            TokenService tokenService = new TokenService();
            int cardLength = customer.Card.Number.ToString().Length;

            int[] lastCardNumbers = new int[4];
            int count = 0;
            foreach(char c in customer.Card.Number.ToString().Substring(cardLength - 4, 4).ToCharArray())
            {
                lastCardNumbers[count++] = Convert.ToInt32(c.ToString());
            }
            customer.Card.Token = new ProjectTokenCard.Model.Token();
            customer.Card.Token.TokenGuid = tokenService.GenerateToken(lastCardNumbers, customer.Card.Ccv);
            customer.Card.Token.Create = DateTime.Now;
            _customerRepository.Add(customer);
            return customer;
        }

        public bool ValidateToken(Customer customer)
        {
            Customer customerEntity = _customerRepository.GetById(customer.CustomerId);
            if (customerEntity.Card.CardId != customer.Card.CardId)
                throw new InvalidOperationException("Customer is not owner of the card");
            if (customerEntity.Card.Token.Create.AddMinutes(30) < DateTime.Now)
                throw new InvalidOperationException("Invalid token");
            if (customerEntity.Card.Token.TokenGuid == customer.Card.Token.TokenGuid)
                return true;
            else
                return false;

        }
    }
}
