using BomacApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BomacApp.Core.Resources.Payments
{
    public class PaymentFormResources
    {
        public int PersonId { get; set; }

        public int ModeId { get; set; }

        public decimal Amount { get; set; }

        public string Ref { get; set; }

        public int? AccountId { get; set; }


        public int TypeId { get; set; }

        [Required]
        public Enums.StockType Type => ((Enums.StockType)TypeId);



    }
}