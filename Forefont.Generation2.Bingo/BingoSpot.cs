namespace Forefont.Generation2.Bingo
{
    public class BingoSpot
    {
        public int Number { get; set; }
        public bool IsChecked { get; set; }

        public BingoSpot()
        {
            IsChecked = false;
        }
    }
}