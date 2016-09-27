using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Collections
{
    class StockValueComparator : IComparer<Asset>
    {
        public int Compare(Asset a, Asset b)
        {
            return b.GetValue().CompareTo(a.GetValue());
        }
    }
}
