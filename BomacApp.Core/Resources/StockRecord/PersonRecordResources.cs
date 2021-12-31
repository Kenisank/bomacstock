using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace BomacApp.Core.Resources.StockRecord
{
    public class PersonRecordResources
    {

        public int Id { get; set; }

        public string Person { get; set; }


        public string Receipt { get; set; }

        public string Type { get; set; }

        public decimal Balance { get; set; }

        public string OrderNum { get; set; }

        public string Total { get; set; }
        public ICollection<RecordViewResources> Records { get; set; }

      


        public PersonRecordResources()
        {
            Records = new Collection<RecordViewResources>();
        }




    }
}