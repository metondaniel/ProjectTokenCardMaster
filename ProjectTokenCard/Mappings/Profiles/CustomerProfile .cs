using AutoMapper;
using ProjectTokenCard.Domain.Model;
using ProjectTokenCard.Dto;
using ProjectTokenCard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTokenCard.Mappings.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<TokenDto, Token>();
            CreateMap<Token, TokenDto>();
            CreateMap<CardDto, Card>();
            CreateMap<Card, CardDto>();
            CreateMap<CustomerDto, Customer>();
            CreateMap<Customer, CustomerDto>();
        }
    }
}
