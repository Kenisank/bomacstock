using AutoMapper;
using BomacApp.Core.Resources.Common;
using BomacApp.Core.Resources.StockItem;
using BomacApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BomacApp.Core.MappingProfile
{
    public class StockItemMapping:Profile
    {


        public StockItemMapping()
        {

            //api resources to model
            CreateMap<CategoryFormResources, StockCategories>()
                .ForMember(a => a.Id, opt => opt.Ignore());


            //api resources to model
            CreateMap<ItemFormResources, StockItems>()
                .ForMember(a => a.Id, opt => opt.Ignore())
                .ForMember(a => a.isAvalible, opt => opt.Ignore());


            //api resources to model 
            CreateMap<QuantityResources, StockQuantity>()
                .ForMember(a => a.TotalSheets, opt => opt.Ignore());


            //model to api resources
            CreateMap<StockItems, ItemSharedResources>()
                .ForMember(a => a.Balance, opt => opt.MapFrom(b => b.NoOfStock))
                .ForMember(a => a.Name, opt => opt.MapFrom(b => $"{ b.Name} {b.Category.Name} {b.Manufactuturer}"));


            //model to api resources
            CreateMap<StockCategories, CategorySharedResources>()
                .ForMember(a => a.Items, opt => opt.MapFrom(b => b.Items.Count().ToString()));


        }



    }
}