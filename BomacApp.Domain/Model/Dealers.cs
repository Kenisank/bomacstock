using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Model
{
    public class Dealers : BusinessPersons
    {
        public string DealerNo => UniqueNumber;


        public Dealers()
        {
            Acr = Dealer;

        }
    }
}
