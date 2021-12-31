using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Model
{
    public class Enums
    {


        public enum EmploymentStatus
        {
            Active=1,
            Suspended=2,
            Relieved=3,
            Retired=4
        }

        public enum StockType
        {
            In=1,
            Out=2
        }

        public enum PersonType
        {
            Dealer = 1,
            Customer = 2
        }

    }
}
