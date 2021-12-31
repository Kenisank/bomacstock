using BomacApp.Domain.Model;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Dal
{
    public class EfContext : IdentityDbContext<ApplicationUser>
    {

        public EfContext() : base("EfContext") { }

        public DbSet<Banks> Banks { get; set; }

        public DbSet<BankAccounts> BankAccounts { get; set; }

        public DbSet<Branches> Branches { get; set; }

        public DbSet<Customers> Customers { get; set; }

        public DbSet<Dealers> Dealers { get; set; }

        public DbSet<Payments> Payments { get; set; }

        public DbSet<PaymentModes> PaymentModes { get; set; }

        public DbSet<PersonRecords> PersonRecords { get; set; }

        public DbSet<Staffs> Staffs { get; set; }

        public DbSet<States> States { get; set; }

        public DbSet<StockCategories> StockCategories { get; set; }

        public DbSet<StockItems> StockItems { get; set; }

        public DbSet<StockRecords> StockRecords { get; set; }

        public DbSet<ReceiptTypes> ReceiptTypes { get; set; }



        public static EfContext Create()
        {
            return new EfContext();
        }


    }
}
