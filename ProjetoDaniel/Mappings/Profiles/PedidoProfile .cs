using AutoMapper;
using ProjetoDaniel.Domain.Model;
using ProjetoDaniel.Dto;
using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDanielWebApi.Mappings.Profiles
{
    public class PedidoProfile : Profile
    {
        public PedidoProfile()
        {
            CreateMap<PedidoDto, Pedido>();
            CreateMap<PizzaDto, Pizza>();
            CreateMap<ClienteDto, Cliente>();
            CreateMap<EnderecoDto, Endereco>();

            CreateMap<TipoPizzaDto, TipoPizza>();
            CreateMap<TipoPizza, TipoPizzaDto>();
            CreateMap<Cliente, ClienteDto>();
        }
    }
}
