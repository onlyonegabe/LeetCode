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
            int[] numbers = { 1, 1 };
            var target = 2;

            CollectionAssert.AreEqual(new[] { 0, 1 }, twoSum.FindIndices(numbers, target));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TwoSum_NullInput_ThrowsArgumentNullException()
        {
            twoSum.FindIndices(null, 0);
        }

        [TestMethod]
        public void TwoSum_TwoAndThreeTargetsFive_IndicesAreOneAndTwo()
        {
            int[] numbers = { 1, 2, 3 };
            var target = 5;

            CollectionAssert.AreEqual(new[] { 1, 2 }, twoSum.FindIndices(numbers, target));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TwoSum_NumbersDontEqualTarget_ThrowsException()
        {
            int[] numbers = { 4, 5 };
            var target = 10;

            twoSum.FindIndices(numbers, target);
        }
    }
}
