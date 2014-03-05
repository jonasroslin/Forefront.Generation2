using System;
using Forefront.Generation2.Lychrel;

namespace Forefront.Generation2.App
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
    }
}
