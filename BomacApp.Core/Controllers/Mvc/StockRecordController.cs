using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BomacApp.Core.Controllers.Mvc
{

    
    public class StockRecordController : Controller
    {

  
        // GET: StockItem
        public ActionResult Index()
        {
            return View("RecordForm");
        }


        public ActionResult All()
        {
            return View("AllRecordForm");
        }



        public ActionResult Persons()
        {
            return View("PersonForm");
        }
        

    }
}