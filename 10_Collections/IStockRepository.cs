using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Collections
{
    public interface IStockRepository
    {
        long  NextId();
        void  SaveStock(Stock stock);
        Stock LoadStock(long id);
        Dictionary<long, Stock> FindAllStocks();
        void Clear();
    }
}
