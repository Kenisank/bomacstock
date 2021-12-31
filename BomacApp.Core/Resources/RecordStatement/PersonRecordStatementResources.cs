using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace BomacApp.Core.Resources.RecordStatement
{
    public class PersonRecordStatementResources
    {
        public int Id { get; set; }

        public ICollection<PersonStatementRecordResources> Records { get; set; }


        public PersonRecordStatementResources()
        {
            Records = new Collection<PersonStatementRecordResources>();
        }
    }
}