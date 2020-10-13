using ProjetoDaniel.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDanielApplication.Interfaces
{
    public interface IClienteAppService
    {
        List<ClienteDto> GetCliente(string nomeCliente);
    }
}
