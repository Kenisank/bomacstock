using BomacApp.Domain.Dal.Repositories.Interfaces;
using BomacApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Dal.Repositories
{
    public class BankAccountRepository:Repository<BankAccounts>, IBankAccountRepository
    {

        private readonly EfContext _context;
        public BankAccountRepository(EfContext context) : base(context)
        {
            _context = context;
        }

    }
}
