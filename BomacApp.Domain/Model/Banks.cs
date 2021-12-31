using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Model
{
    public class Banks
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<BankAccounts> Accounts { get; set; }



        public Banks()
        {
            Accounts = new Collection<BankAccounts>();
        }

    }
}
