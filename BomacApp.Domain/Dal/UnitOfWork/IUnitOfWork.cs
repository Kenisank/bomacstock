using BomacApp.Domain.Dal.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Dal.UnitOfWork
{
    public interface IUnitOfWork
    {

        IStockCategoryRepository StockCategories { get; set; }

        IStockItemRepository StockItems { get; set; }


        IStockRecordRepository StockRecords { get; set; }

        IPaymentRepository Payments { get; set; }


        IDealerRepository Dealers { get; set; }

        ICustomerRepository Customers { get; set; }

        IStateRepository States { get; set; }

        IReceiptTypeRepository ReceiptTypes { get; set; }

        IPersonRecordRepository PersonRecords { get; set; }



        IBankAccountRepository BankAccounts { get; set; }

        IPaymentModeRepository PaymentModes { get; set; }

        IBankRepository Banks { get; set; }

        bool Save();

        void Dispose();



    }
}
