using BomacApp.Domain.Common;
using BomacApp.Domain.Dal.UnitOfWork;

using BomacApp.Domain.Services.Interfaces;
using BomacApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Services
{
    public class StockRecordServices : IStockRecordServices
    {

        private readonly IUnitOfWork _unitofwork;


        public StockRecordServices(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }


        public StockRecords AddRecord(StockRecords record)
        {
            if (record != null)
            {

                var item = _unitofwork.StockItems.Get(record.ItemId);

                if (item != null)
                {


                    EvaluateItem(record, item);

                    _unitofwork.StockRecords.Add(record);

                    if (_unitofwork.Save())
                        return record;

                }


            }

            return null;
        }




        public IEnumerable<StockRecords> AddPersonRecord(PersonRecords personrecords, IEnumerable<StockRecords> stockrecords)
        {

            if (personrecords != null && stockrecords.Count() > 0)
            {

                //var person = _unitofwork.Dealers.Get(personrecords.PersonId);
                var persons = AllPersons();
                var person = persons.FirstOrDefault(a => a.Id == personrecords.PersonId);
                var receipt = _unitofwork.ReceiptTypes.Get(personrecords.ReceiptId);


                if (person != null)
                {
                    
                    if (personrecords.ReceiptId > 0)
                    {
                        if (personrecords.ReceiptNumber == null || personrecords.ReceiptNumber == "")
                        {
                            return null;
                        }

                    }


                    foreach (var record in stockrecords)
                    {

                        var item = _unitofwork.StockItems.Get(record.ItemId);

                        if (item != null)
                        {
                            EvaluateItem(record, item);
                            // record.RecordId = personrecords.Id;
                            record.Destination = person.Name;
                           person.Balance= getBalance(record, person.Balance, record.Amount);
     
                            personrecords.Records.Add(record);
                          
                        }

                        

                    }

                    _unitofwork.PersonRecords.Add(personrecords);



                    if (_unitofwork.Save())
                        return personrecords.Records;


                }
            }

            return null;


        }











        private int getSheetsLeft(StockRecords record, int sheetsLeft, int recordSheets)
        {
            if (record.Type == Enums.StockType.Out)
            {
                if (sheetsLeft >= recordSheets)
                {

                    sheetsLeft -= recordSheets;

                }
            }
            if (record.Type == Enums.StockType.In)
            {

                sheetsLeft += recordSheets;
            }

            return sheetsLeft;

        }



        private decimal getBalance(StockRecords record, decimal personBalance, decimal recordAmount)
        {
            if (record.Type == Enums.StockType.Out)
              personBalance -= recordAmount;


            
            else if (record.Type == Enums.StockType.In)
             personBalance += recordAmount;

        
            return personBalance;

        }




        public IEnumerable<BusinessPersons> AllPersons()
        {
            var customers = _unitofwork.Customers.Getall();
            var dealers = _unitofwork.Dealers.Getall();

            var businessperson = new List<BusinessPersons>();
            businessperson.AddRange(customers);
            businessperson.AddRange(dealers);

            return businessperson;
        }






        private void EvaluateItem(StockRecords record, StockItems item)
        {

            record.Quantity.NoOfSheets = item.NoOfSheets;


            var sheetsLeft = item.NoOfStock.TotalSheets;

            var recordSheets = record.Quantity.TotalSheets;
            //GeneralMethods.ConvertToSheet(item, record.Quantity);

            sheetsLeft = getSheetsLeft(record, sheetsLeft, recordSheets);

            GeneralMethods.ConvertToReamsAndSheets(item, sheetsLeft);
            record.Balance.NoOfSheets = item.NoOfSheets;
            record.Balance.Reams = item.NoOfStock.Reams;
            record.Balance.Sheets = item.NoOfStock.Sheets;


        }










    }
}


