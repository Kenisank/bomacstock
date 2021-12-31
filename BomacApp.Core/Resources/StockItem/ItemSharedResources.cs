using BomacApp.Core.Resources.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BomacApp.Core.Resources.StockItem
{
    public class ItemSharedResources
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public QuantityResources Balance { get; set; }

       
  }
}