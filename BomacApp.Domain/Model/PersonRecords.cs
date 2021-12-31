using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Model
{
    public class PersonRecords
    {

        public int Id { get; set; }


        public virtual ICollection<StockRecords> Records { get; set; }


        public int PersonId { get; set; }
        public virtual BusinessPersons Person { get; set; }

        public decimal Amount => Records.Sum(a => a.Amount);


        public int ReceiptId { get; set; }

        public virtual ReceiptTypes Receipt { get; set; }

        public string ReceiptNumber { get; set; }


        public DateTime DateAdded { get; set; }



        public PersonRecords()
        {
            Records = new Collection<StockRecords>();
            DateAdded = DateTime.Now;
        }

    }
}
