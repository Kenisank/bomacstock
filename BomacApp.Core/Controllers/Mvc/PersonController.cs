using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BomacApp.Core.Controllers.Mvc
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View("PersonForm");
        }


        [HttpGet]
        public ActionResult Orders()
        {
            return View("OrderForm");
        }

        public ActionResult Statements()
        {
            return View("StatementForm");
        }



        public ActionResult Test()
        {
            return View("PersonResourceForm");
        }
    }
}
