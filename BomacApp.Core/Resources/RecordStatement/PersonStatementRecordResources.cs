using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BomacApp.Core.Resources.RecordStatement
{
    public class PersonStatementRecordResources 
    {
        public int Id { get; set; }

        public string StockNo { get; set; }

        public string Description { get; set; }

       // public string Ref { get; set; }

        public string Debit { get; set; }

        public string Credit { get; set; }

        public string Balance { get; set; }

        public string Amount { get; set; }

        public string Date { get; set;}

        public string Type { get; set; }
        public DateTime DateAdded { get; internal set; }

        private readonly string In = "In";

        private readonly string Out = "Out";



        public void getAccountState()
        {

            Debit = Type == Out ? Amount.ToString() : "";

            Credit = Type == In ? Amount.ToString() : "";

        }




    }
}