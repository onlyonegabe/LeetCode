using System;

namespace TwoSum
{
    public class TwoSum
    {
        public int[] FindIndices(int[] numbers, int target)
        {
            if (numbers == null) throw new ArgumentNullException();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                var firstNumber = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    var secondNumber = numbers[j];
                    if (NumbersAddUpToTarget(target, firstNumber, secondNumber))
                    {
                        return new[] { i, j };
                    }
                }
            }

            return new int[] { };
        }

        private static bool NumbersAddUpToTarget(int target, int firstNumber, int secondNumber) => firstNumber + secondNumber == target;
    }
}
