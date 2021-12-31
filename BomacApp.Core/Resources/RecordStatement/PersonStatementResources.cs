using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace BomacApp.Core.Resources.RecordStatement
{
    public class PersonStatementResources
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public string UniqueNo { get; set; }

        public string Phone { get; set; }

        public string State { get; set; }

        public string Balance { get; set; }

        public ICollection<PersonRecordStatementResources> Records { get; set; }



        public PersonStatementResources()
        {
            Records = new Collection<PersonRecordStatementResources>();
        }


    }
}