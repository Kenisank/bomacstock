
using BomacApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Services.Interfaces
{
    public interface IStockItemServices
    {

        StockCategories AddCategory(StockCategories _category);

        bool DeleteCategory(int Id);

        StockItems AddStockItem(StockItems item);

        bool DeleteStockItem(int Id);

    }
}
