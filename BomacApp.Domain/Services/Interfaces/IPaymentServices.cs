using BomacApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Services.Interfaces
{
    public interface IPaymentServices
    {
        Payments AddPayment(Payments payment);
    }
}
