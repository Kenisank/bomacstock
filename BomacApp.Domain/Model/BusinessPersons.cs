using BomacApp.Domain.Dal.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Model
{
    public class BusinessPersons
    {

        private IUnitOfWork _unitofwork;

        public int Id { get; set; }

        public string Name { get; set; }

        public string Acr { get; set; }

        public decimal Balance { get; set; }


        public string Address { get; set; }

        public int StateId { get; set; }
        public virtual States State { get; set; }


        public string UniqueNumber { get; private set; }


        public virtual Contact Contact { get; set; }


        public virtual ICollection<PersonRecords> Records { get; set; }

        public virtual ICollection<Payments> Payments { get; set; }


        public virtual IEnumerable<Locations> Locations { get; set; }



        public string Dealer => "DEA";

        public string Customer => "CUS";




        public BusinessPersons()
        {

            Records = new Collection<PersonRecords>();

            Payments = new Collection<Payments>();

            Locations = new Collection<Locations>();


        }


        public string GenerateUniqueNumber(IUnitOfWork unitOfWork)
        {
            _unitofwork = unitOfWork;

            var TotalPersons = (_unitofwork.Customers.Getall().Count() + _unitofwork.Dealers.Getall().Count());



            UniqueNumber = $"{Acr}{(++TotalPersons).ToString().PadLeft(7, '0')}";


            return UniqueNumber;
        }

        }
    }
