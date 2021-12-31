using BomacApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BomacApp.Core.Controllers.Mvc
{

    [AllowAnonymous]

    public class AuthController : Controller
    {
        [HttpGet]
        // GET: Auth
        public ActionResult Login(string returnUrl)
        {
            //if (User.Identity.IsAuthenticated)
            //{
            //    return LogOut();
            //}
            var model = new LoginView
            {
                ReturnUrl = returnUrl
            };
            return View(model);
        }


        [HttpPost]
        public ActionResult Login(LoginView loginView)
        {
            if (!ModelState.IsValid)
            {
                return View(loginView);
            }

            return View(loginView);


        }


        private ActionResult LogOut()
        {
            throw new NotImplementedException();
        }
    }
}