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

        [DataTestMethod]
        [DataRow(new[] { 1, 1 }, 2, new[] { 0, 1 })]
        [DataRow(new[] { 1, 2, 3 }, 5, new[] { 1, 2 })]
        public void TwoSum_NumbersEqualTarget_CorrectIndicesAreReturned(int[] numbers, int target, int[] expected)
        {
            int[] actual = twoSum.FindIndices(numbers, target);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TwoSum_NullInput_ThrowsArgumentNullException()
        {
            twoSum.FindIndices(null, 0);
        }

        [TestMethod]
        public void TwoSum_NumbersDontEqualTarget_ReturnsEmptyResult()
        {
            int[] numbers = { 4, 5 };
            var target = 10;

            int[] actual = twoSum.FindIndices(numbers, target);

            CollectionAssert.AreEqual(new int[] { }, actual);
        }
    }
}
