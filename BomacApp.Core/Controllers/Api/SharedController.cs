using AutoMapper;
using BomacApp.Core.Resources.Common;
using BomacApp.Core.Resources.Payments;
using BomacApp.Core.Resources.Person;
using BomacApp.Core.Resources.StockItem;
using BomacApp.Domain.Dal.UnitOfWork;
using BomacApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BomacApp.Core.Controllers.Api
{

    [RoutePrefix("api/shared")]
    public class SharedController : ApiController
    {


        private readonly IUnitOfWork _unitofwork;

        public SharedController() { }


        public SharedController(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;

        }


        [Route("categories")]
        public IHttpActionResult GetCategories()
        {
            var categories = Mapper.Map<IEnumerable<KeyPairValueResources>>(_unitofwork.StockCategories.Getall());
            return Ok(categories.OrderBy(a=>a.Name));
        }



        [Route("items")]
        public IHttpActionResult GetItems()
        {

            var items = Mapper.Map<IEnumerable<ItemSharedResources>>(_unitofwork.StockItems.Getall().OrderBy(a => a.CategoryId));

            return Ok(items);
        }


        [Route("states")]
        public IHttpActionResult GetStates()
        {

            var states = Mapper.Map<IEnumerable<KeyPairValueResources>>(_unitofwork.States.Getall());

            return Ok(states);
        }


        [Route("modes")]
        public IHttpActionResult GetModes()
        {
            var modes = Mapper.Map<IEnumerable<KeyPairValueResources>>(_unitofwork.PaymentModes.Getall());

            return Ok(modes);
        }

        [Route("banks")]
        public IHttpActionResult GetBanks()
        {
            var banks = Mapper.Map<IEnumerable<BankSharedResources>>(_unitofwork.Banks.Getall());

            return Ok(banks);
        }


        [Route("accounts")]
        public IHttpActionResult GetAccounts()
        {
            var accounts = Mapper.Map<IEnumerable<KeyPairValueResources>>(_unitofwork.BankAccounts.Getall());

            return Ok(accounts);
        }


        [Route("enums")]
        public IHttpActionResult GetEnums()
        {
            return Ok(new EnumResources());
        }



        [Route("persons")]
        public IHttpActionResult GetDealers()
        {
            var dealers = _unitofwork.Dealers.Getall();

            var customers = _unitofwork.Customers.Getall();

            var persons = new List<BusinessPersons>();
            persons.AddRange(dealers);
            persons.AddRange(customers);

            var resources = Mapper.Map<IEnumerable<PersonSharedResources>>(persons);


            return Ok(resources);
        }


        [Route("receipts")]
        public IHttpActionResult GetReceiptTypes()
        {
            var types = Mapper.Map<IEnumerable<KeyPairValueResources>>(_unitofwork.ReceiptTypes.Getall());



            return Ok(types);
        }


        [HttpGet]
        [Route("allcategories")]
        public IHttpActionResult AllCategories()
        {
            var categories = Mapper.Map<IEnumerable<CategorySharedResources>>(_unitofwork.StockCategories.Getall());
            return Ok(categories.OrderBy(a => a.Name));

        }





    }




}
