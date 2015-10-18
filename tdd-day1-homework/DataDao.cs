using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_day1_homework
{
    public class DataDao : IDataDao
    {
        public IList<ProductInfo> GetData()
        {
            var data = new List<ProductInfo>();
            data.Add(new ProductInfo { Id = 11, Cost = 11, Revenue = 111, SellPrice = 21 });
            data.Add(new ProductInfo { Id = 12, Cost = 12, Revenue = 121, SellPrice = 22 });
            data.Add(new ProductInfo { Id = 13, Cost = 13, Revenue = 131, SellPrice = 23 });
            data.Add(new ProductInfo { Id = 14, Cost = 14, Revenue = 141, SellPrice = 24 });
            data.Add(new ProductInfo { Id = 15, Cost = 15, Revenue = 151, SellPrice = 25 });
            data.Add(new ProductInfo { Id = 16, Cost = 16, Revenue = 161, SellPrice = 26 });
            data.Add(new ProductInfo { Id = 17, Cost = 17, Revenue = 171, SellPrice = 27 });
            data.Add(new ProductInfo { Id = 18, Cost = 18, Revenue = 181, SellPrice = 28 });
            data.Add(new ProductInfo { Id = 19, Cost = 19, Revenue = 191, SellPrice = 29 });
            data.Add(new ProductInfo { Id = 110, Cost = 110, Revenue = 120, SellPrice = 30 });
            data.Add(new ProductInfo { Id = 111, Cost = 111, Revenue = 121, SellPrice = 31 });

            return data;
        }
    }
}
