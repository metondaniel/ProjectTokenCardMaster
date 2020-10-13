using ProjetoDaniel.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDanielApplication.Interfaces
{
    public interface IPizzaAppService
    {
        List<PizzaDto> GetPrato(TipoPizzaDto dtoRequest);

        PizzaDto GetPratoById(Guid id);
    }
}
