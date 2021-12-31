using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace BomacApp.Core.Resources.StockRecord
{
    public class PersonRecordFormResources
    {


        //public int PersonId { get; set; }


        //public int ReceiptId { get; set; }

        //public string ReceiptNumber { get; set; }


        public PersonRecordFormDetailResources RecordDetails { get; set; }


        public ICollection<RecordFormResources> Records { get; set; }

            

       

        public PersonRecordFormResources()
        {
            Records = new Collection<RecordFormResources>();
            //RecordDetails = new PersonRecordFormDetailResources();
        }


    }
}