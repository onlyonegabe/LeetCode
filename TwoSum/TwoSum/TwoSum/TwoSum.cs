﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TwoSum
{
    public class TwoSum
    {
        private int differenceIndex;
        private int subtrahendIndex;

        public int[] FindIndices(int[] numbers, int target)
        {
            if (numbers == null) throw new ArgumentNullException();
            if (AnyDuplicateElements(numbers)) throw new Exception("An element has been found twice");

            GetIndices(numbers, target);

            if (IndicesWereNotFound())
            {
                throw new Exception("Indices were not found.");
            }

            return new[] { differenceIndex, subtrahendIndex };
        }

        private static bool AnyDuplicateElements(IEnumerable<int> numbers)
            => numbers.GroupBy(x => x)
                .Where(x => x.Count() > 1)
                .Select(x => x).Any();

        private void GetIndices(int[] numbers, int target)
        {
            var indicesByNumber = new Hashtable();
            differenceIndex = -1;
            subtrahendIndex = -1;
            for (var i = 0; i < numbers.Length; i++)
            {
                int subtrahend = numbers[i];
                int difference = target - subtrahend;
                if (indicesByNumber.Contains(difference))
                {
                    if (IndicesWereNotFound())
                    {
                        differenceIndex = int.Parse(indicesByNumber[difference].ToString());
                        subtrahendIndex = i;
                    }
                    else
                    {
                        throw new Exception("There are multiple solutions detected.");
                    }
                }

                indicesByNumber.Add(subtrahend, i);
            }
        }

        private bool IndicesWereNotFound()
            => differenceIndex == -1 || subtrahendIndex == -1;
    }
}
