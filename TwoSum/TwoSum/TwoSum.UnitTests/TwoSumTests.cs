using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TwoSum.UnitTests
{
    [TestClass]
    public class TwoSumTests
    {
        private TwoSum twoSum;

        [TestInitialize]
        public void SetUp()
        {
            twoSum = new TwoSum();
        }

        [TestMethod]
        public void TwoSum_OneAndOneTargetsTwo_IndicesAreZeroAndOne()
        {
            int[] numbers = {1, 1};

            CollectionAssert.AreEqual(new[] { 0, 1 }, twoSum.FindIndices(numbers));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TwoSum_NullInput_ThrowsArgumentNullException()
        {
            twoSum.FindIndices(null);
        }
    }
}
