using FluentAssertions;
using Forefont.Generation2.Bingo;
using NUnit.Framework;

namespace Forefront.Generation2.Bingo.Tests
{
    [TestFixture]
    public class BingoSpotTests
    {
        [Test]
        public void IsChecked_should_be_false_by_default()
        {
            var bingoSpot = new BingoSpot();
            bingoSpot.IsChecked.Should().BeFalse();
        }
    }
}