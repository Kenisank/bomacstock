using System.Collections.Generic;

namespace BomacApp.Core.Resources.Accounts
{
    public class ProfileResources
    {


        public string Name { get; set; }
        public string Email { get; set; }

        public IEnumerable<string> Roles { get; set; }

    }
}