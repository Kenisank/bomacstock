using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BomacApp.Core.Resources.RecordStatement
{
    public class PersonStatementsResources
    {
        public PersonRecordDetailResources Person { get; set; }

        public ICollection<PersonStatementRecordResources> Records { get; set; }

    }
}