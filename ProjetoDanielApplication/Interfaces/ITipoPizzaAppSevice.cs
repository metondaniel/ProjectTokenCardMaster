using ProjetoDaniel.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDanielApplication.Interfaces
{
    public interface ITipoPizzaAppSevice
    {
        List<TipoPizzaDto> GetAll();
    }
}
