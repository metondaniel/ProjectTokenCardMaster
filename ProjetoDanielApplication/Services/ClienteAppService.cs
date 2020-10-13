using AutoMapper;
using ProjetoDaniel.Domain.Interfaces.Services;
using ProjetoDaniel.Domain.Model;
using ProjetoDaniel.Dto;
using ProjetoDanielApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDanielApplication.Services
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly IClienteService _service;
        private readonly IMapper _mapper;
        public ClienteAppService(IClienteService RestauranteService, IMapper mapper)
        {
            _service = RestauranteService;
            _mapper = mapper;
        }

        public List<ClienteDto> GetCliente(string nomeCliente)
        {
            return _mapper.Map<List<ClienteDto>>(_service.GetCliente(nomeCliente));
        }
    }
}
