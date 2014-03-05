using System;
using System.Numerics;

namespace Forefront.Generation2.Lychrel.Tests
{
    public class LychrelNumberEasy : ICheckForLychrelNumber
    {
        public bool IsLychrel(int number)
        {
            BigInteger testNumber = number;
            for (var i = 0; i < 50; i++)
            {
                testNumber += ReverseNumber(testNumber);
                if (IsPalindrome(testNumber)) return false;
            }
            return true;
        }

        private bool IsPalindrome(BigInteger number)
        {
            return number == ReverseNumber(number);
        }

        private BigInteger ReverseNumber(BigInteger number)
        {
            var numberAsArray = number.ToString().ToCharArray();
            Array.Reverse(numberAsArray);
            return BigInteger.Parse(new string(numberAsArray));
        }
    }
}
