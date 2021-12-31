using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Model
{
    public class BankAccounts
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Number { get; set; }

        public int BankId { get; set; }

        public virtual Banks Bank { get; set; }

    }
}
