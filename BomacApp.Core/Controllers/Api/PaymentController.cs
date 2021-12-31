using AutoMapper;
using BomacApp.Core.Resources.Payments;
using BomacApp.Domain.Dal.UnitOfWork;
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

    [RoutePrefix("api/payments")]
    public class PaymentController : ApiController
    {

        private readonly IUnitOfWork _unitofwork;

        private readonly IPaymentServices _paymentservice;


        public PaymentController() { }


        public PaymentController(IUnitOfWork unitofwork, IPaymentServices paymentservice)
        {
            _unitofwork = unitofwork;
            _paymentservice = paymentservice;
        }




        [HttpPost]
        [Route("add")]
        public IHttpActionResult AddPayment(PaymentFormResources resource)
        {
            var payment = Mapper.Map<Payments>(resource);

            var personpayment = _paymentservice.AddPayment(payment);

            return Ok();

        }





    }
}
