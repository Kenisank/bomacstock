﻿using BomacApp.Core.Resources.StockRecord;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace BomacApp.Core.Resources.RecordStatement
{
    public class PersonRecordPersonDetailsResources
    {
        public int Id { get; set; }

        public string Person { get; set; }


        public string Receipt { get; set; }

        public string Type { get; set; }

        public decimal Balance { get; set; }

        public string OrderNum { get; set; }

        public string Total { get; set; }

        public ICollection<RecordViewResources> Records { get; set; }


        public PersonRecordPersonDetailsResources()
        {
            Records = new Collection<RecordViewResources>();
        }
    }
}