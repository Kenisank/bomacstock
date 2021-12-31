using BomacApp.Core.Resources.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BomacApp.Core.Resources.StockItem
{

    
    public class ItemFormResources
    {
       
        public string Name { get; set; }

         
        public int NoOfSheets { get; set; }

        public QuantityResources NoOfStock { get; set; }
        public string Manufactuturer { get; set; }

        public int CategoryId { get; set; }
        
    }
}