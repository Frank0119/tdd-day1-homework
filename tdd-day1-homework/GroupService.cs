using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tdd_day1_homework
{
    public class GroupService
    {
        private IDataDao _dataDao;

        public GroupService(IDataDao dataDao)
        {
            _dataDao = dataDao;
        }

        public IList<int> GetPagingData(int pagingSize, Func<ProductInfo, int> selector)
        {
            IList<int> result = new List<int>();
            var data = this._dataDao.GetData();
            int page = (int)Math.Ceiling((double)data.Count / (double)pagingSize);

            for (int i = 0; i < page; i++)
            {
                result.Add(data.Skip(i * pagingSize).Take(pagingSize).Sum(selector));
            }

            return result;
        }
    }
}
