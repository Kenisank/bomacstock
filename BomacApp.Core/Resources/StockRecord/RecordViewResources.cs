using BomacApp.Core.Resources.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BomacApp.Core.Resources.StockRecord
{
    public class RecordViewResources
    {
     
     
        public string Item { get; set; }

        public QuantityResources Quantity { get; set; }

        public bool isDamaged { get; set; }

        public decimal Amount { get; set; }


    }
}