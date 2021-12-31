using BomacApp.Core.Resources.Common;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BomacApp.Core.Resources.Payments
{
    public class BankSharedResources
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<KeyPairValueResources> Accounts { get; set; }



        public BankSharedResources()
        {
            Accounts = new Collection<KeyPairValueResources>();
        }


    }
}