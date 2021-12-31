using BomacApp.Core.Resources.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BomacApp.Core.Resources.Person
{
    public class DealerFormResources
    {


        public string Name { get; set; }

        public ContactFormResources Contact { get; set; }

        public string Address { get; set; }

        public int StateId { get; set; }


    }
}