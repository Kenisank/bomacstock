using AutoMapper;
using BomacApp.Core.Resources.Person;
using BomacApp.Domain.Dal.UnitOfWork;
using BomacApp.Domain.Model;

using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BomacApp.Core.Controllers.Api
{

    [RoutePrefix("api/persons")]
    public class PersonController : ApiController
    {

        private readonly IUnitOfWork _unitofwork;

        public PersonController(){ }
        
        
       

        public PersonController(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
           
        }


        [Route("add")]
        public IHttpActionResult AddPerson(PersonFormResources resources)
        {
            if (resources != null)
            {

                var person = new object();


                if(resources.Type == Enums.PersonType.Dealer)
                {
                    var dealer = Mapper.Map<Dealers>(resources);

                    dealer.GenerateUniqueNumber(_unitofwork);


                    _unitofwork.Dealers.Add(dealer);

                    person = Mapper.Map<PersonsResouces>(dealer);
                }

               else if (resources.Type == Enums.PersonType.Customer)
                {
                    var customer = Mapper.Map<Customers>(resources);

                    customer.GenerateUniqueNumber(_unitofwork);

                   _unitofwork.Customers.Add(customer);

                    person = Mapper.Map<PersonsResouces>(customer);

                }

                var result = Mapper.Map<PersonsResouces>(person);

                if (_unitofwork.Save())
                {
                    return Ok(result);
                }

               
            }

            return InternalServerError();
            
        }






        [HttpGet]
        [Route("all")]
        public IHttpActionResult AllPersons()
        {
           
            var customers = _unitofwork.Customers.Getall();
            var dealers = _unitofwork.Dealers.Getall();

            var businessperson = new List<BusinessPersons>();
            businessperson.AddRange(customers);
            businessperson.AddRange(dealers);


            var result = Mapper.Map<IEnumerable<PersonsResouces>>(businessperson);

          

            return Ok(result);

        }





   


    }
}
