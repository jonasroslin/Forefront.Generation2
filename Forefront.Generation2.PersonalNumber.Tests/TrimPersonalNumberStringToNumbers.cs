using System;
using System.Collections.Generic;

namespace Forefront.Generation2.PersonalNumber.Tests
{
    public static class TrimPersonalNumberStringToNumbers
    {
        public static List<int> Trim(string personalNumber)
        {
            personalNumber = personalNumber.Replace("-", "");

            List<int> personalNumberAsArray = new List<int>();

            for (int i = 0; i < personalNumber.Length-1; i++)
            {
                string c = personalNumber[i].ToString();
                personalNumberAsArray.Add(Convert.ToInt32(c));
            }


            return personalNumberAsArray;
        }
    }
}