using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Collections
{
    class Portfolio
    {
        private List<Asset> assets = new List<Asset>();

        public Portfolio(){}

        public Portfolio(List<Asset> assets)
        {
            this.assets = assets;
        }

        public double GetTotalValue()
        {
            return assets.Sum(asset => asset.GetValue());
        }

        public void AddAsset(Asset asset)
        {
            assets.Add(asset);
        }

        public List<Asset> GetAssets()
        {
            return assets;
        }

        public Asset GetAssetByName(String name)
        {
            return assets.Find(asset => asset.GetName() == name);
        }

        public List<Asset> GetAssetsSortedByName()
        {
            assets.Sort(new StockNameComparator());
            return assets;
        }

        public List<Asset> GetAssetsSortedByValue()
        {
            assets.Sort(new StockValueComparator());
            return assets;
        }

    }
}
