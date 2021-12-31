using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Model
{
    public class Locations
    {
        public int Id { get; set; }

        public string Address { get; set; }

        public string SPhoneNo { get; set; }

        public int StateId { get; set; }
        public virtual States State { get; set; }
    }
}
