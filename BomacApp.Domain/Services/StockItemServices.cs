using BomacApp.Domain.Dal.UnitOfWork;
using BomacApp.Domain.Model;
using BomacApp.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Services
{
    public class StockItemServices : IStockItemServices
    {

        private readonly IUnitOfWork _unitofwork;


        public StockItemServices(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;

        }



        public StockCategories AddCategory(StockCategories _category)
        {


            _category.Name = _category.Name.ToString().ToUpper().Trim();

            if (_category.Name != null && _category.Name != "" &&
               ! (_unitofwork.StockCategories.Find(a => a.Name == _category.Name).Any()))


            {
               _unitofwork.StockCategories.Add(_category);

                if (_unitofwork.Save())
                    return _category;
            }


            return null;

        }


        public bool DeleteCategory(int Id)
        {

            if (Id != 0 || Id > 0)
            {
                var category = _unitofwork.StockCategories.Get(Id);

                if (category != null)
                {
                    _unitofwork.StockCategories.Remove(category);

                    if (_unitofwork.Save())
                        return true;
                }
            }


            return false;
        }

        public StockItems AddStockItem(StockItems item)
        {
            item.Name = item.Name.ToString().ToUpper().Trim();

            if (item != null && item.Name != null && item.Name != "" )
                /*&&( _unitofwork.StockItems.Getall().Any(a => a.Name != item.Name))*/
            {
                _unitofwork.StockItems.Add(item);

                if (_unitofwork.Save())
                    return item;
            }

            return null;
        }

        public bool DeleteStockItem(int Id)
        {
            if (Id != 0 || Id > 0)
            {

                var item = _unitofwork.StockItems.Get(Id);


                if (item != null)
                {

                    _unitofwork.StockItems.Remove(item);

                    if (_unitofwork.Save())
                        return true;

                }


            }

            return false;

        }






    }
}
