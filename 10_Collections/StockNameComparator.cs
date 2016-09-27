using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Collections
{
    class StockNameComparator : IComparer<Asset>
    {
        public int Compare(Asset a, Asset b)
        {
            return a.GetName().CompareTo(b.GetName());
        }
    }
}
