using AutoMapper;
using BomacApp.Core.Resources.Common;
using BomacApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BomacApp.Core.MappingProfile
{
    public class SharedMapping:Profile
    {
        public SharedMapping()
        {


            //model to api
            CreateMap<StockCategories, KeyPairValueResources>();

            //model to api
            CreateMap<StockItems, KeyPairValueResources>()
                .ForMember(a => a.Name, opt => opt.MapFrom(b => $"{ b.Name} {b.Category.Name}"));

            //model to api
            CreateMap<States, KeyPairValueResources>();




        }


    }
}