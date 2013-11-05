using System.Collections.Generic;
using System.Linq;

namespace Forefront.Generation2.PersonalNumber.Tests
{
    public static class GetControllNumberOfAPersonalNumber
    {
        public static int Get(string personalNumber)
        {
            List<int> numbers = TrimPersonalNumberStringToNumbers.Trim(personalNumber).ToList();

            var results = new List<int>();
            for (var i = 0; i < numbers.Count(); i++)
            {
                if (IsOdd(i + 1))
                {
                    int valueOnCurrentPosition = numbers[i] * 2;
                    if (valueOnCurrentPosition >= 10)
                    {
                        results.Add(valueOnCurrentPosition / 10);
                        results.Add(valueOnCurrentPosition % 10);
                    }
                    else
                        results.Add(valueOnCurrentPosition);
                }
                else
                    results.Add(numbers[i]);
            }

            return 10 - (results.Sum() % 10);
        }

        private static bool IsOdd(int i)
        {
            return i % 2 != 0;
        }

    }
}