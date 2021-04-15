using AutoMapper;
using ProjectTokenCard.Mappings.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTokenCard.Mappings
{
    public class AutoMapperConfiguration
    {
        #region Public Static Methods

        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(profile => { profile.AddProfile(new CustomerProfile()); profile.AddProfile(new CustomerProfile()); });
        }

        #endregion
    }
}
