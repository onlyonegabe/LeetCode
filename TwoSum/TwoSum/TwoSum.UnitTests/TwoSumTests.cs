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
        [DataRow(new[] { 1, 3 }, 4, new[] { 0, 1 }, DisplayName = "First happy path case")]
        [DataRow(new[] { 1, 2, 3 }, 5, new[] { 1, 2 }, DisplayName = "Second happy path case")]
        [DataRow(new[] { 1, 2, 3, 9, 5 }, 8, new[] { 2, 4 }, DisplayName = "Third happy path case")]
        [DataRow(new[] { 1, -5, 6 }, 1, new[] { 1, 2 }, DisplayName = "Happy path including negative numbers")]
        public void FindIndices_NumbersEqualTarget_CorrectIndicesAreReturned(int[] numbers, int target, int[] expected)
        {
            int[] actual = twoSum.FindIndices(numbers, target);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FindIndices_NullInput_ThrowsArgumentNullException()
        {
            twoSum.FindIndices(null, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void FindIndices_NumbersDoNotEqualTarget_ReturnsEmptyResult()
        {
            int[] numbers = { 4, 5 };
            var target = 10;

            twoSum.FindIndices(numbers, target);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void FindIndices_TwoNumbersAreTheSame_ThrowsException()
        {
            twoSum.FindIndices(new[] { 1, 1 }, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void FindIndices_MoreThanOneSolution_ThrowsException()
        {
            int[] numbers = { 2, 8, 4, 6 };
            var target = 10;

            twoSum.FindIndices(numbers, target);
        }
    }
}
