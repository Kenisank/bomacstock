using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Model
{
    public class StockCategories
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateAdded => DateTime.Now;

        public virtual ICollection<StockItems> Items { get; set; }

        public string StaffNo { get; set; }

        public StockCategories()
        {
            Items = new Collection<StockItems>();
        }

    }
}
