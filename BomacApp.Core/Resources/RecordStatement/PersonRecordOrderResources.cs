using BomacApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BomacApp.Core.Resources.RecordStatement
{
    public class PersonRecordOrderResources
    {
        public int Id { get; set; }
        public string Date { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public string Ref { get; set; }

        public string Credit { get; set; }

        public string Debit { get; set; }

        public decimal Amount { get; set; }

        public decimal Balance { get; set; }



        private readonly string In = "In";

        private readonly string Out = "Out";



        public void getAccountState()
        {

            Debit = Type.ToString() == Out ? Amount.ToString() : " ";

            Credit = Type.ToString() == In ? Amount.ToString() : " ";

        }


    }
}