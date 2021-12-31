using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BomacApp.Core.Controllers
{

    [RoutePrefix("api/roles")]
    public class RolesMangerController : BaseApiController
    {

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAllRoles()
        {

            return Ok(AppRoleManager.Roles.Select(a => a.Name));
        }

    }
}
