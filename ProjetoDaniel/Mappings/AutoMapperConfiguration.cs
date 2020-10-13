using AutoMapper;
using ProjetoDanielWebApi.Mappings.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDanielWebApi.Mappings
{
    public class AutoMapperConfiguration
    {
        #region Public Static Methods

        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(profile => { profile.AddProfile(new PedidoProfile()); profile.AddProfile(new PedidoProfile()); });
        }

        #endregion
    }
}
