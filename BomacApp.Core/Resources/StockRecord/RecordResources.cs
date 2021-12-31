using BomacApp.Core.Resources.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BomacApp.Core.Resources.StockRecord
{
    public class RecordResources
    {
        public QuantityResources Quantity { get; set; }
        public  QuantityResources Balance { get; set; }

        public string Type { get; set; }

        public bool isDamaged { get; set; }

        public string Destination { get; set; }

        public string Item { get; set; }
       

        public string StaffNo { get; set; }

        public string DateAdded { get; set; }

        public string DateA { get; set; }


        //public void GetTime()
        //{
        //    //Set the time zone information to W.Central Africa Standard Time
        //    var timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("W. Central Africa Standard Time");

        //    //Get date and time in W. Central Africa Standard Time 
        //    DateAdded = TimeZoneInfo.ConvertTime(DateTime.Now, timeZoneInfo);

        //    DateA = DateAdded.ToString("dd/MM/yyyy HH:mm");


        //}

    }

    
}