using AutoMapper;
using BomacApp.Core.DTOs;
using BomacApp.Core.Resources.RecordStatement;
using BomacApp.Core.Resources.StockRecord;
using BomacApp.Domain.Dal.UnitOfWork;
using BomacApp.Domain.Model;
using BomacApp.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web.Http;

namespace BomacApp.Core.Controllers.Api
{


    [RoutePrefix("api/records")]
    public class StockRecordController : ApiController
    {
        private readonly IStockRecordServices _recordservices;
        private readonly IUnitOfWork _unitofwork;

        

        public StockRecordController() { }

        public StockRecordController(IStockRecordServices recordservivces, IUnitOfWork unitofwork)
        {
            _recordservices = recordservivces;
            _unitofwork = unitofwork;
           
        }
      

        [HttpPost]
        [Route("new")]
        public IHttpActionResult NewRecord(RecordFormResources resource)
        {
            //if (!ModelState.IsValid)
            //    return BadRequest(ModelState);

            var stockrecord = Mapper.Map<StockRecords>(resource);

            var record = _recordservices.AddRecord(stockrecord);

            var result = Mapper.Map<RecordResources>(record);


            return Ok(result);

        }

        [HttpPost]
        [Route("personrecords")]
        public IHttpActionResult NewPersonRecord(PersonRecordFormResources resource)
        {

            var personrecord = Mapper.Map<PersonRecords>(resource.RecordDetails);

            var records = Mapper.Map<IEnumerable<StockRecords>>(resource.Records);

            var record = _recordservices.AddPersonRecord(personrecord, records);

           var result = Mapper.Map<IEnumerable<RecordResources>>(record);

            return Ok(result);
        }



        [HttpGet]
        [Route("")]
        public IHttpActionResult AllRecord()
        {
            var records = Mapper.Map<IEnumerable<RecordResources>>(_unitofwork.StockRecords.Getall());
           
            return Ok(records);
        }


        [HttpGet]
        [Route("daily")]
        public IHttpActionResult DailyRecord()
        {
            var records = Mapper.Map<IEnumerable<RecordResources>>(_unitofwork.StockRecords.Getall().Where(a => a.DateAdded.Date == DateTime.Today.Date));



            return Ok(records);
        }


        [HttpGet]
        [Route("singledetails/{num:int}")]
        public IHttpActionResult SingleDeta(int num)
        {
            //var detail = _unitofwork.PersonRecords.Getall().FirstOrDefault(a => a.DateAdded.ToString("dd/MM/yyyy HH:MM") == num);
            var detail = _unitofwork.PersonRecords.Get(num);
            var result =Mapper.Map<PersonRecordPersonDetailsResources>(detail);

            return Ok(result);

        }



        [HttpGet]
        [Route("statements/{num:int}")]
        public IHttpActionResult SingleDetails(int num)
        {
            var person = AllPersons().FirstOrDefault(a => a.Id == num);

            var result = Mapper.Map<PersonRecordDetailResources>(person);


            return Ok(result);
        }




        [HttpGet]
        [Route("statements/records/{Id:int}")]
        public IHttpActionResult Statements(int Id)
        {
          var person = AllPersons().FirstOrDefault(a => a.Id == Id);
           

            var records = new List<StockRecords>();

            foreach (var item in person.Records)
            {
                records.AddRange(item.Records);
            }


            var result = Mapper.Map<IEnumerable<PersonRecordOrderResources>>(records);

            foreach (var output in result)
            {
                output.getAccountState();
            }

            return Ok(result);
        }





        public IEnumerable<BusinessPersons> AllPersons()
        {
            var customers = _unitofwork.Customers.Getall();
            var dealers = _unitofwork.Dealers.Getall();

            var businessperson = new List<BusinessPersons>();
            businessperson.AddRange(customers);
            businessperson.AddRange(dealers);

            return businessperson;
        }



    }
}
