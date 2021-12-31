using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BomacApp.Core.Controllers.Mvc
{

    [RoutePrefix("stocks/item")]
    public class StockItemController : Controller
    {
        // GET: StockItem
        public ActionResult Index()
        {
            return View("ItemForm");
        }


        public ActionResult Category()
        {
            return View("");
        }


    }
}