using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Model
{
    public class Customers: BusinessPersons
    {



        public string CustomerNo => UniqueNumber;








        public Customers()
        {
            Acr = Customer;


        }


    }
}
