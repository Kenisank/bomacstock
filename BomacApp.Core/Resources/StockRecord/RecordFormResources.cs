using BomacApp.Core.Resources.Common;
using BomacApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BomacApp.Core.Resources.StockRecord
{
    public class RecordFormResources
    {

        public int TypeId { get; set; }

        [Required]
        public Enums.StockType Type => ((Enums.StockType)TypeId);


        [Required]
        public int ItemId { get; set; }

        public QuantityResources Quantity { get; set; }

        public bool isDamaged { get; set; }

        public decimal Amount { get; set; }


        //public RecordFormResources()
        //{
        //    isDamaged = true;
        //}

        



    }
}