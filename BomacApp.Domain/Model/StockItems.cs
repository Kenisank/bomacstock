using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Model
{
    public class StockItems
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public bool isAvalible { get; set; }

        public int NoOfSheets { get; set; }

        public virtual StockQuantity NoOfStock { get; set; }

        public string Manufactuturer { get; set; }

        public int CategoryId { get; set; }
        public virtual StockCategories Category { get; set; }

        public DateTime DateAdded => DateTime.Now;


        public string StaffNo { get; set; }


        public StockItems()
        {
            NoOfStock = new StockQuantity();
        }



       


    }
}
