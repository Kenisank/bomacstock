using AutoMapper;
using BomacApp.Core.Resources.Accounts;
using BomacApp.Domain.Model;

namespace BomacApp.Core.MappingProfile
{
    public class UserAccountsMapping:Profile
    {

        public UserAccountsMapping()
        {
            CreateMap<RegisterResources, ApplicationUser>();
        }


    }
}