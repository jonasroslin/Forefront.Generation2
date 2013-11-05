using System;
using System.Collections.Generic;

namespace Forefront.Generation2.PersonalNumber.Tests
{
    public static class TrimPersonalNumberStringToNumbers
    {
        public static IEnumerable<int> Trim(string personalNumber)
        {
            personalNumber = personalNumber.Replace("-", string.Empty);

            var ints = new List<int>();
            for (var i = 0; i < personalNumber.Length-1; i++)
            {
                ints.Add(Convert.ToInt32(personalNumber[i].ToString()));
            }

            return ints;
        }
    }
}