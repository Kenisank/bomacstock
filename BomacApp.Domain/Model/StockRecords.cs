using BomacApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Model
{


    public class StockRecords
    {

        public int Id { get; set; }

        public virtual StockQuantity Quantity { get; set; }
        public virtual StockQuantity Balance { get; set; }

        public decimal PendingBalance { get; set; }

        public Enums.StockType Type { get; set; }


        public bool isCredit { get; set; }

        public bool isDamaged { get; set; }

        public string Destination { get; set; }

        public int ItemId { get; set; }
        public virtual StockItems Item { get; set; }

        public string StaffNo { get; set; }

        public decimal Amount { get; set; }

        public DateTime DateAdded { get; set; }


        public int? RecordId { get; set; }
        public virtual PersonRecords Record { get; set; }


        public StockRecords()
        {
            Destination = "Sales";
            Quantity = new StockQuantity();
            Balance = new StockQuantity();
            DateAdded = DateTime.Now;
        }


    }


}