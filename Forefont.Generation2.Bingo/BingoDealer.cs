using System;
using System.Collections.Generic;
using System.Linq;

namespace Forefont.Generation2.Bingo
{
    public class BingoDealer
    {
        public List<int> BingoNumbers { get; private set; }

        public BingoDealer()
        {
            BingoNumbers = new List<int>();
            FillBingoNumbers();
        }

        private void FillBingoNumbers()
        {
            for (var x = 1; x < 26; x++)
                BingoNumbers.Add(x);
        }

        public void Shuffle()
        {
            BingoNumbers = BingoNumbers.OrderBy(x => Guid.NewGuid()).ToList();
        }
    }
}