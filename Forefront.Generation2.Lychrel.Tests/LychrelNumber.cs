using System;
using NUnit.Framework;

namespace Forefront.Generation2.Lychrel.Tests
{
    [TestFixture]
    public class When_checking_if_number_is_a_lychrel_number
    {
        [Test]
        public void Number_should_be_a_lychrel_number()
        {
            ICheckForLychrelNumber lychrelNumber = new LychrelNumberEasy();
            bool isLychrel = lychrelNumber.IsLychrel(196);
            Assert.IsTrue(isLychrel);
        }

        [Test]
        public void Number_should_not_be_a_lychrel_number()
        {
            ICheckForLychrelNumber lychrelNumber = new LychrelNumberEasy();
            bool isLychrel = lychrelNumber.IsLychrel(349);
            Assert.IsFalse(isLychrel);
        }
    }
}