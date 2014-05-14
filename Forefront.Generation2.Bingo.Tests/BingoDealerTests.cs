using System.Linq;
using FluentAssertions;
using Forefont.Generation2.Bingo;
using NUnit.Framework;

namespace Forefront.Generation2.Bingo.Tests
{
    [TestFixture]
    public class BingoDealerTests
    {
        [Test]
        public void Delar_should_have_25_numbers()
        {
            var bingoDealer = new BingoDealer();
            bingoDealer.BingoNumbers.Should().HaveCount(25);
        }

        [Test]
        public void Shuffle_should_change_order_of_list()
        {
            var bingoDealer = new BingoDealer();
            int first = bingoDealer.BingoNumbers.First();
            bingoDealer.Shuffle();
            bingoDealer.BingoNumbers.First().Should().NotBe(first);
        }
    }
}
