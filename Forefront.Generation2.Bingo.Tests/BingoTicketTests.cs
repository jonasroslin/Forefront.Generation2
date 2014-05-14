using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Forefont.Generation2.Bingo;
using NUnit.Framework;

namespace Forefront.Generation2.Bingo.Tests
{
    [TestFixture]
    public class BingoTicketTests
    {
        private readonly BingoTicket _bingoTicket = new BingoTicket();

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            _bingoTicket.PopulateTicket(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25});
        }

        [Test]
        public void Matrix_should_have_5_rows()
        {
            _bingoTicket.TicketMatrix.Should().HaveCount(5);
        }

        [Test]
        public void Matrix_should_have_5_columns()
        {
            _bingoTicket.TicketMatrix.First().Should().HaveCount(5);
        }
    }
}