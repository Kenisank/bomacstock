using BomacApp.Domain.Dal.UnitOfWork;
using BomacApp.Domain.Model;
using BomacApp.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Services
{
    public class PaymentServices: IPaymentServices
    {

        private readonly IUnitOfWork _unitofwork;

        public PaymentServices(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }


        public Payments AddPayment(Payments payment)
        {
            var person = AllPersons().FirstOrDefault(a=>a.Id==payment.PersonId);

            if (person != null)
            {

                payment.Total = person.Balance;
                payment.GeneratePaymentNumber(_unitofwork);
                _unitofwork.Payments.Add(payment);
                person.Balance = payment.PendingBalance;
                if (_unitofwork.Save()){ return payment; }

            }

            return null;

        }

         IEnumerable<BusinessPersons> AllPersons()
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
