using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TwoSum.UnitTests
{
    [TestClass]
    public class TwoSumTests
    {
        [TestMethod]
        public void TwoSum_OneAndOneTargetsTwo_IndicesZeroAndOne()
        {
            var twoSum = new TwoSum();
            int[] numbers = new[] {1, 1};

            int[] result = twoSum.FindIndices(numbers);

            CollectionAssert.AreEqual(new[] { 0, 1 }, result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TwoSum_NullInput_ThowsException()
        {
            var twoSum = new TwoSum();

            int[] result = twoSum.FindIndices(null);
        }
    }
}
