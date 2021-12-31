using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Model
{
    public class StockQuantity
    {

        public int NoOfSheets { get; set; }

        public int Reams { get; set; }

        public int Sheets { get; set; }

        public int TotalSheets => (Reams * NoOfSheets) + Sheets;
    }
}
