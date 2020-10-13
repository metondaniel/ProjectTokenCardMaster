using AutoMapper;
using ProjetoDaniel.Domain.Builder;
using ProjetoDaniel.Domain.Interfaces.Services;
using ProjetoDaniel.Domain.Model;
using ProjetoDaniel.Dto;
using ProjetoDaniel.Model;
using ProjetoDanielApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDanielApplication.Services
{
    public class PizzaAppService : IPizzaAppService
    {
        private readonly IPizzaService _service;
        private readonly IMapper _mapper;
        public PizzaAppService(IPizzaService pratoService, IMapper mapper)
        {
            _service = pratoService;
            _mapper = mapper;
        }

        public List<PizzaDto> GetPrato(TipoPizzaDto dtoRequest)
        {
            return _mapper.Map<List<PizzaDto>>(_service.GetByParam(_mapper.Map<TipoPizza>(dtoRequest)));
        }

        public PizzaDto GetPratoById(Guid id)
        {
            return _mapper.Map<PizzaDto>(_service.GetById(id));
        }

        
    }
}
