using BomacApp.Core.Resources.Payments;
using BomacApp.Core.Resources.StockRecord;

namespace BomacApp.Core.DTOs
{
    public class CustomerRecordPaymentDto
    {
        public PersonRecordFormResources Record { get; set; }

        public PaymentFormResources Payment { get; set; }

    }
}