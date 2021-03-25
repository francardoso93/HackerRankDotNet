using System.Collections.Generic;
using Xunit;
using Exercise1;

namespace Exercise1_tests
{
    public class ResultTest
    {
        public static TheoryData<List<int>, List<int>, List<int>, List<int>, int, long> testData
        {
            get
            {
                var data = new TheoryData<List<int>, List<int>, List<int>, List<int>, int, long>();
                data.Add(new List<int> { 2, 3 }, new List<int> { 4 }, new List<int> { 2 }, new List<int> { 1, 2, 3 }, 10, 3);
                data.Add(new List<int> { 4 }, new List<int> { 3, 4, 1 }, new List<int> { 3, 2 }, new List<int> { 4 }, 12, 2);
                data.Add(new List<int> { 4 }, new List<int> { 3, 4, 1 }, new List<int> { 3, 2 }, new List<int> { 4 }, 3, 0); // Cannot buy all 4
                return data;
            }
        }


        [Theory, MemberData(nameof(testData))]
        public void GetNumberOfOptions(List<int> priceOfJeans, List<int> priceOfShoes, List<int> priceOfSkirts, List<int> priceOfTops, int dollars, long expectedResult)
        {
            long currentResult = Result.GetNumberOfOptions(priceOfJeans, priceOfShoes, priceOfSkirts, priceOfTops, dollars);
            Assert.Equal(expectedResult, currentResult);
        }
    }
}
