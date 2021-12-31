using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(BomacApp.Core.Startup))]

namespace BomacApp.Core
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
           
        }
    }
}
