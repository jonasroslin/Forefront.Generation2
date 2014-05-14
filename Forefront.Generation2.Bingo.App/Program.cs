using System;
using Forefont.Generation2.Bingo;

namespace Forefront.Generation2.Bingo.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var bingoDealer = new BingoDealer();
            bingoDealer.Shuffle();
            var bingoTicket = new BingoTicket();
            bingoTicket.PopulateTicket(bingoDealer.BingoNumbers);
            bingoDealer.Shuffle();
            Print(bingoTicket);
            Console.ReadLine();
            foreach (var number in bingoDealer.BingoNumbers)
            {
                bingoTicket.TickNumber(number);
                Print(bingoTicket);
                Console.WriteLine(number);
                if (bingoTicket.IsBingo())
                {
                    Console.WriteLine("BINGO!");
                    break;
                }
                Console.ReadLine();
            }
        }

        private static void Print(BingoTicket bingoTicket)
        {
            Console.Clear();
            Console.WriteLine("B\tI\tN\tG\tO");
            Console.WriteLine("-------------------------------------");
            foreach (var ints in bingoTicket.TicketMatrix)
            {
                foreach (var i in ints)
                {
                    if (i.IsChecked)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;;
                        Console.Write("X \t");
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.Write(i.Number + " \t");    
                    }
                }
                   
                Console.WriteLine("");
            }
            Console.ResetColor();
            Console.WriteLine("______________________________________");
        }
    }
}
