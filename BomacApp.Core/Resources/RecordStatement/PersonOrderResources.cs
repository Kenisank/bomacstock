using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace BomacApp.Core.Resources.RecordStatement
{
    public class PersonOrderResources
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string UniqueNo { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Balance { get; set; }

        public string Total => Records.Sum(a => a.Amount).ToString("NGN #,##0.00");
        public ICollection<PersonRecordOrderResources> Records { get; set; }



        public PersonOrderResources()
        {
            Records = new Collection<PersonRecordOrderResources>();
        }



    }
}