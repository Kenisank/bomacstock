using BomacApp.Domain.Dal.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Model
{
    public class Payments
    {
        private IUnitOfWork _unitofwork;

        public int Id { get; set; }

        public decimal Total { get; set; }

        public decimal AmountPaid { get; set; }

        public int ModeId { get; set; }

        public virtual PaymentModes Mode { get; set; }

        public string Ref { get; set; }

        public string PaymentNo { get; set; }

        public decimal PendingBalance => Total + AmountPaid;

        public int AccountId { get; set; }
        public virtual BankAccounts Account { get; set; }


        public int PersonId { get; set; }
        public virtual BusinessPersons Person { get; set; }


        public DateTime DateAdded { get; set; }


        public Enums.StockType Type { get;set; }


        public void GeneratePaymentNumber(IUnitOfWork unitOfWork)
        {
            _unitofwork = unitOfWork;

            var dailyTotalPay = (_unitofwork.Payments.Getall().Count(a=>a.DateAdded==DateTime.Now));

            var date = TimeZoneInfo.ConvertTime(DateAdded, TimeZoneInfo.FindSystemTimeZoneById("W. Central Africa Standard Time")).ToString("ddMMyy");

           PaymentNo = $"PAY{date}{(++dailyTotalPay).ToString().PadLeft(3, '0')}";
        }



        public Payments()
        {
            DateAdded = DateTime.Now;
        }



    }
}
