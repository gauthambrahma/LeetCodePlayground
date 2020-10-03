using System;
using System.Collections.Generic;
using playground;
using Xunit;

namespace PlaygroudTest
{
    public class combinationSumTest
    {
        private readonly combinationSum combinationSum;
        IList<List<int>> expectedResult = new List<List<int>>();

        public combinationSumTest()
        {
            combinationSum = new combinationSum();
        }

        [Fact]
        public void input1()
        {
            int[] candidates = new int[] { 2, 3, 6, 7 };
            var result = combinationSum.CombinationSum(candidates, 7);
            List<int> input = new List<int> { 2, 2, 3 };
            expectedResult.Add(new List<int>(input));
            input = new List<int> { 7 };
            expectedResult.Add(new List<int>(input));
	        Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void input2()
        {
            int[] candidates = new int[] { 2, 3, 5 };
            var result = combinationSum.CombinationSum(candidates, 8);
            List<int> input = new List<int> { 2, 2, 2,2};
            expectedResult.Add(new List<int>(input));
            input = new List<int> { 2,3,3 };
            expectedResult.Add(new List<int>(input));
            input = new List<int> { 3, 5 };
            expectedResult.Add(new List<int>(input));
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void input3()
        {
            int[] candidates = new int[] { 2 };
            var result = combinationSum.CombinationSum(candidates, 1);
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void input4()
        {
            int[] candidates = new int[] { 1 };
            var result = combinationSum.CombinationSum(candidates, 1);
            List<int> input = new List<int>{1};
            expectedResult.Add(new List<int>(input));
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void input5()
        {
            int[] candidates = new int[] { 1 };
            var result = combinationSum.CombinationSum(candidates, 2);
            List<int> input = new List<int> { 1,1 };
            expectedResult.Add(new List<int>(input));
            Assert.Equal(expectedResult, result);
        }
    }
}
