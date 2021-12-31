using BomacApp.Domain.Dal.UnitOfWork;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Services
{
    public class PersonServices
    {


        private readonly IUnitOfWork _unitofwork;


        public PersonServices(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }



        //public BusinessPersons AddPerson(BusinessPersons person)
        //{


        //    if (person != null)
        //    {
        //        person.GenerateUniqueNumber(_unitofwork);


        //        if (person.Acr == person.Dealer)
        //            _unitofwork.Dealers.Add(person);


        //        if (_unitofwork.Save())
        //        {
        //            return Ok();
        //        }

        //    }



        //}








    }
}
