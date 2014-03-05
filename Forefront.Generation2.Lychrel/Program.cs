using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Forefront.Generation2.Lychrel.Tests;

namespace Forefront.Generation2.Lychrel
{
    class Program
    {
        static void Main(string[] args)
        {
            const int start = 10;
            const int limit = 10000;
            int result = 0;

            var lychrelNumber = new LychrelNumberEasy();

            for (int i = start; i < limit; i++)
            {
                if (lychrelNumber.IsLychrel(i))
                {
                    Console.WriteLine("{0} is Lychrel", i);
                    result++;
                }

            }

            Console.WriteLine(result);

        }

        //private static bool IsLychrel(int number)
        //{
        //    BigInteger testNumber = number;
        //    for (var i = 0; i < 50; i++)
        //    {
        //        testNumber += ReverseNumber(testNumber);
        //        if (IsPalindrome(testNumber)) return false;
        //    }
        //    return true;
        //}

        //private static BigInteger ReverseNumber(BigInteger number)
        //{
        //    var numberAsArray = number.ToString().ToCharArray();
        //    Array.Reverse(numberAsArray);
        //    return BigInteger.Parse(new string(numberAsArray));
        //}

        //private static bool IsPalindrome(BigInteger number)
        //{
        //    return number == ReverseNumber(number);
        //}
    }
}
