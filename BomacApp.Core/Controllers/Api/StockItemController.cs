using AutoMapper;
using BomacApp.Core.Resources.StockItem;
using BomacApp.Domain.Model;
using BomacApp.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BomacApp.Core.Controllers.Api
{

    [RoutePrefix("api/stock")]
    public class StockItemController : ApiController
    {

        private readonly IStockItemServices _stockitemservices;
        public StockItemController() { }

        public StockItemController(IStockItemServices stockitemservices)
        {
            _stockitemservices = stockitemservices;
        }

        [HttpPost]
        [Route("categories/add")]
        public IHttpActionResult AddCategory(CategoryFormResources resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            var category = Mapper.Map<StockCategories>(resource);

            var result =_stockitemservices.AddCategory(category);

           
            return Ok(result);

           

        }


        [Route("items/add")]
        public IHttpActionResult AddItem (ItemFormResources resource)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var item = Mapper.Map<StockItems>(resource);
            item.NoOfStock.NoOfSheets = item.NoOfSheets;
            var result = _stockitemservices.AddStockItem(item);

           
                return Ok(result);

        

        }

        //[HttpGet]
        //[Route("items")]
        //public IHttpActionResult AllItems()
        //{

        //    var items = Mapper.Map<IEnumerable<>>

        //}




   



    }
}
