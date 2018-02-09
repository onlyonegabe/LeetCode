using System;

namespace TwoSum
{
    public class TwoSum
    {
        public int[] FindIndices(int[] numbers, int target)
        {
            if (numbers == null) throw new ArgumentNullException();

            for (int i = 0; i < numbers.Length; i++)
            {
                var firstNumber = numbers[i];
                for (int j = 1; j < numbers.Length; j++)
                {
                    var secondNumber = numbers[j];
                    if (NumbersAddUpToTarget(target, firstNumber, secondNumber))
                    {
                        return new[] { i, j };
                    }
                }
            }

            return new[] { 0, 1 };
        }

        private static bool NumbersAddUpToTarget(int target, int firstNumber, int secondNumber) => firstNumber + secondNumber == target;
    }
}
