using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using BomacApp.Core.App_Start;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace BomacApp.Core.Controllers
{
    public class BaseApiController : ApiController
    {


        private readonly ApplicationUserManager __appUserManager = null;
        private ApplicationRoleManager _AppRoleManager = null;



        public ISecureDataFormat<AuthenticationTicket> AccessTokenFormat { get; private set; }
        protected ApplicationUserManager AppUserManager => __appUserManager ?? Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
        protected ApplicationRoleManager AppRoleManager => _AppRoleManager ?? Request.GetOwinContext().GetUserManager<ApplicationRoleManager>();
        protected IAuthenticationManager Authentication => Request.GetOwinContext().Authentication;




        public BaseApiController() { }





        protected IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if (result == null)
            {
                return InternalServerError();
            }


            if (!result.Succeeded)
            {
                if (result.Errors != null)
                {
                    foreach (string error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }

                if (ModelState.IsValid)
                {

                    // No ModelState errors are available to send, so just return an empty BadRequest.
                    return BadRequest();

                }

                return BadRequest(ModelState);


            }


            return null;

        }







    }
}
