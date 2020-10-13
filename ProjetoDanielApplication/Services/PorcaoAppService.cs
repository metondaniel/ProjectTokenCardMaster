using AutoMapper;
using ProjetoDaniel.Domain.Interfaces.Services;
using ProjetoDaniel.Dto;
using ProjetoDanielApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDanielApplication.Services
{
    public class PorcaoAppService : IPorcaoAppService
    {
        private readonly IPorcaoService _service;
        private readonly IMapper _mapper;
        public PorcaoAppService(IPorcaoService RestauranteService, IMapper mapper)
        {
            _service = RestauranteService;
            _mapper = mapper;
        }

        public List<PorcaoDto> GetAll()
        {
            return _mapper.Map<List<PorcaoDto>>(_service.GetAll());
        }
    }
}
