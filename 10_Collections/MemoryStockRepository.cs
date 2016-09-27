using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Collections
{
    class MemoryStockRepository : IStockRepository
    {
        private long Id = 0;
        private Dictionary<long, Stock> stocks = new Dictionary<long, Stock>();

        public long NextId() { return ++Id; }

        public void SaveStock(Stock stock)
        {
            stock.Id = NextId();
            stocks.Add(stock.Id, stock);
        }

        public Stock LoadStock(long id)
        {
            return stocks[id];
        }


    }
}
