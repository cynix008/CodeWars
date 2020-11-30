using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars
{
    public class TwoSums
    {
        //1,3,4 = 7
        public static int[] GetTwoNumbers(int[] numbers, int target)
        {
            Dictionary<int,int> numberToFind  =  new Dictionary<int, int>();
            var resultEfficient = new int[2];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > target) continue;
                var missingNumber =  target - numbers[i];

                if (numberToFind.ContainsKey(missingNumber))
                {
                    resultEfficient[0] = numberToFind.GetValueOrDefault(missingNumber);
                    resultEfficient[1] = i;
                    return resultEfficient;
                }

                if (numberToFind.ContainsKey(numbers[i]))
                {
                    resultEfficient[0] = numberToFind.GetValueOrDefault(numbers[i]);
                    resultEfficient[1] = i;
                    return resultEfficient;
                }
                numberToFind.Add(missingNumber, i);
            }

            return resultEfficient;
        }
    }
}
