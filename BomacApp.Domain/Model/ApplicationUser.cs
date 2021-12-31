using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }

    }
}
