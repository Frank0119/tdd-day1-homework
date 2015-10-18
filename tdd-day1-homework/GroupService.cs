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

        public IList<int> GetPagingData(int pagingSize, string sumField)
        {
            IList<int> result = new List<int>();
            var data = this._dataDao.GetData();
            int page = (int)Math.Ceiling((double)data.Count / (double)pagingSize);

            for (int i = 0; i < page; i++)
            {
                var temp = sumField == "Cost";
                switch (sumField)
                {
                    case "Cost":
                        result.Add(data.Skip(i * pagingSize).Take(pagingSize).Sum(x => x.Cost));
                        break;
                    case "Revenue":
                        result.Add(data.Skip(i * pagingSize).Take(pagingSize).Sum(x => x.Revenue));
                        break;
                }
            }

            return result;
        }
    }
}
