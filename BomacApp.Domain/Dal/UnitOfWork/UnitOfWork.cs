using BomacApp.Domain.Dal.Repositories;
using BomacApp.Domain.Dal.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Dal.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly EfContext _context;

        public UnitOfWork(EfContext context)
        {
            _context = context;

            StockCategories = new StockCategoryRepository(context);

            StockItems = new StockItemRepository(context);

            StockRecords = new StockRecordRepository(context);

            Dealers = new DealerRepository(context);

            Customers = new CustomerRepository(context);

            States = new StateRepository(context);

            ReceiptTypes = new ReceiptTypeRepository(context);

            PersonRecords = new PersonRecordRepository(context);

            PaymentModes = new PaymentModeRepository(context);

            BankAccounts = new BankAccountRepository(context);

            Banks = new BankRepository(context);

            Payments = new PaymentRepository(context);


        }



        public IStockCategoryRepository StockCategories { get; set; }

        public IStockItemRepository StockItems { get; set; }

        public IStockRecordRepository StockRecords { get; set; }

        public IDealerRepository Dealers { get; set; }

        public ICustomerRepository Customers { get; set; }

        public IStateRepository States { get; set; }

        public IReceiptTypeRepository ReceiptTypes { get; set; }

        public IPersonRecordRepository PersonRecords { get; set; }

        public IBankAccountRepository BankAccounts { get; set; }

        public IPaymentModeRepository PaymentModes { get; set; }

        public IBankRepository Banks { get; set; }

        public IPaymentRepository Payments { get; set; }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
