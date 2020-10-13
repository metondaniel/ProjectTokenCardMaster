using AutoMapper;
using ProjetoDaniel.Domain.Interfaces.Services;
using ProjetoDaniel.Dto;
using ProjetoDaniel.Model;
using ProjetoDanielApplication.Interfaces;
using ProjetoDaniel.Domain.Builder;
using System;
using System.Collections.Generic;
using System.Text;
using ProjetoDaniel.Domain.Model;

namespace ProjetoDanielApplication.Services
{
    public class PedidoAppService : IPedidoAppService
    {
        private readonly IPedidoService _service;
        private readonly IMapper _mapper;
        public PedidoAppService(IPedidoService RestauranteService, IMapper mapper)
        {
            _service = RestauranteService;
            _mapper = mapper;
        }

        public void DeletePedido(Guid RestauranteId)
        {
            throw new NotImplementedException();
        }

        public List<PedidoDto> GetPedido(string nomeCliente)
        {
            return _mapper.Map<List<PedidoDto>>(_service.GetByParam(nomeCliente));
        }

        public PedidoDto GetPedidoById(Guid id)
        {
            return _mapper.Map<PedidoDto>(_service.GetById(id));
        }

        public PedidoDto SavePedido(PedidoDto dtoRequest)
        {
            var RestauranteBuilder = new PedidoBuilder()
                .WithDate(dtoRequest.Data)
                .WithCliente(_mapper.Map<Cliente>(dtoRequest.Cliente))
                .WithPizza(_mapper.Map<List<Pizza>>(dtoRequest.Pizza));
            return _mapper.Map<PedidoDto>(_service.Add(RestauranteBuilder.Instance));
        }


        public void UpdatePedido(PedidoDto dtoRequest)
        {
            //var RestauranteBuilder = new PedidoBuilder()
            //    .WithId(dtoRequest.Id);
            //_service.Update(RestauranteBuilder.Instance);
        }
    }
}
