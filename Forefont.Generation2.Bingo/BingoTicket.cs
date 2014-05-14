using System.Collections.Generic;
using System.Linq;

namespace Forefont.Generation2.Bingo
{
    public class BingoTicket
    {
        public List<List<BingoSpot>> TicketMatrix { get; set; }

        public BingoTicket()
        {
            TicketMatrix = new List<List<BingoSpot>>();
        }

        public void PopulateTicket(List<int> bingoNumbers)
        {
            int c = 0;
            for (var i = 0; i < 5; i++)
            {
                var row = new List<BingoSpot>();
                for (var j = 0; j < 5; j++)
                {
                    row.Add(new BingoSpot { Number = bingoNumbers[c] });
                    c++;
                }

                TicketMatrix.Add(row);
            }
        }
        
        public void TickNumber(int numberToTick)
        {
            foreach (var row in TicketMatrix)
                if (row.Any(y => y.Number == numberToTick))
                    row.First(x => x.Number == numberToTick).IsChecked = true;
        }

        public bool IsBingo()
        {
            return TicketMatrix.Any(row => row.All(x => x.IsChecked));

            //foreach (var row in TicketMatrix)
            //{
            //    if (row.All(x => x.IsChecked))
            //        return true;
            //}

            //return false;
        }
    }
}