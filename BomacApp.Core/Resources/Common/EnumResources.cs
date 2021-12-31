using BomacApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BomacApp.Core.Resources.Common
{
    public class EnumResources
    {
        public string[] StockTypes { get; set; }

        public string[] PersonTypes { get; set; }



        public EnumResources()
        {
            StockTypes= Enum.GetNames(typeof(Enums.StockType));
            PersonTypes = Enum.GetNames(typeof(Enums.PersonType));


        }
    }
}