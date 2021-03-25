using System;
using Xunit;
using exercise3;

namespace exercise3_tests
{
    public class SolutionTest
    {
        Solution solution;
        public static TheoryData<int, int, int[], int[], long> testData
        {
            get
            {
                var data = new TheoryData<int, int, int[], int[], long>();
                data.Add(6, 6, new int[] { 2, 4 }, new int[] { 2 }, 4);
                data.Add(3, 3, new int[] { 2 }, new int[] { 2 }, 4);
                data.Add(3, 2, new int[] { 1, 2, 3 }, new int[] { 1, 2 }, 12);
                return data;
            }
        }

        public SolutionTest()
        {
            solution = new Solution();
        }

        [Theory, MemberData(nameof(testData))]
        public void StorageOptimization(int horizontalTotal, int verticalTotal, int[] horizontalCuts, int[] verticalCuts, long expectedResult)
        {
            long currentResult = solution.StorageOptimization(horizontalTotal, verticalTotal, horizontalCuts, verticalCuts);
            Assert.Equal(expectedResult, currentResult);
        }
    }
}
