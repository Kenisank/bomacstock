using BomacApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Common
{
    public static class GeneralMethods
    {

        ////public static void ConvertToSheet(StockItems item, StockQuantity qtn)
        ////{
        ////    qtn.TotalSheets = (item.NoOfSheets * qtn.Reams) + qtn.Sheets;
        ////}

        public static void ConvertToReamsAndSheets(StockItems item, int sheetsLeft)
        {
            item.NoOfStock.Sheets = sheetsLeft % (item.NoOfSheets);
            item.NoOfStock.Reams = (sheetsLeft - (item.NoOfStock.Sheets))/(item.NoOfSheets);

        }


    }
}
