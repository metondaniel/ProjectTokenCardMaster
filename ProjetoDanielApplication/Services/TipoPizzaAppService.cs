using AutoMapper;
using ProjetoDaniel.Domain.Interfaces.Services;
using ProjetoDaniel.Dto;
using ProjetoDanielApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDanielApplication.Services
{
    public class TipoPizzaAppService : ITipoPizzaAppSevice
    {
        private readonly ITipoPizzaService _service;
        private readonly IMapper _mapper;
        public TipoPizzaAppService(ITipoPizzaService RestauranteService, IMapper mapper)
        {
            _service = RestauranteService;
            _mapper = mapper;
        }

        public List<TipoPizzaDto> GetAll()
        {
            return _mapper.Map<List<TipoPizzaDto>>(_service.GetAll());
        }
    }
}
