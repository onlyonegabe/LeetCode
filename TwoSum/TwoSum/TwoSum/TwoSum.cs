using System;
using System.Collections;

namespace TwoSum
{
    public class TwoSum
    {
        public int[] FindIndices(int[] numbers, int target)
        {
            if (numbers == null) throw new ArgumentNullException();

            var indicesByNumber = new Hashtable();
            for (var i = 0; i < numbers.Length; i++)
            {
                int difference = target - numbers[i];
                if (indicesByNumber.Contains(difference))
                {
                    var indexOfDifferenceFound = int.Parse(indicesByNumber[difference].ToString());
                    return new[] { indexOfDifferenceFound, i };
                }

                indicesByNumber.Add(numbers[i], i);
            }

            return new int[] { };
        }
    }
}
