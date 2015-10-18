using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using tdd_day1_homework;
using System.Collections.Generic;
using ExpectedObjects;

namespace tdd_day1_homeworkTests
{
    [TestClass]
    public class GroupServiceTests
    {
        private static IList<ProductInfo> testData;

        [ClassInitialize()]
        public static void MyClassInitialize()
        {
            testData = new List<ProductInfo>();
            testData.Add(new ProductInfo { Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 });
            testData.Add(new ProductInfo { Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 });
            testData.Add(new ProductInfo { Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 });
            testData.Add(new ProductInfo { Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 });
            testData.Add(new ProductInfo { Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 });
            testData.Add(new ProductInfo { Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 });
            testData.Add(new ProductInfo { Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 });
            testData.Add(new ProductInfo { Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 });
            testData.Add(new ProductInfo { Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 });
            testData.Add(new ProductInfo { Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 });
            testData.Add(new ProductInfo { Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 });
        }

        [ClassCleanup()]
        public static void MyClassCleanup()
        {
            testData = null;
        }

        [TestMethod]
        public void Test_Paging_Size_3_Result()
        {
            // Arrange
            var pagingSize = 3;
            var sumField = "Cost";
            var dataDao = Substitute.For<IDataDao>();
            dataDao.GetData().Returns(testData);
            var expected = new int[] { 6, 15, 24, 21 };

            var target = new GroupService(dataDao);

            // Act
            var actual = target.GetPagingData(pagingSize, sumField);

            // Assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod]
        public void Test_Paging_Size_4_Result()
        {
            // Arrange
            var pagingSize = 4;
            var sumField = "Revenue";
            var dataDao = Substitute.For<IDataDao>();
            dataDao.GetData().Returns(testData);
            var expected = new int[] { 50, 66, 60 };

            var target = new GroupService(dataDao);

            // Act
            var actual = target.GetPagingData(pagingSize, sumField);

            // Assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}
