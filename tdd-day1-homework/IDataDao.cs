using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tdd_day1_homework
{
    public interface IDataDao
    {
        IList<ProductInfo> GetData();
    }
}
