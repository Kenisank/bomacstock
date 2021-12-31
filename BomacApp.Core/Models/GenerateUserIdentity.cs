using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using BomacApp.Domain.Model;
using Microsoft.AspNet.Identity;

namespace BomacApp.Core.Models
{
    public static class GenerateUserIdentity
    {


        public static async Task<ClaimsIdentity> GenerateUserIdentityAsync(ApplicationUser user, UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(user, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }
}