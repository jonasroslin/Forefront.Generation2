using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace Forefront.Generation2.PersonalNumber.Tests
{
    [TestFixture]
    public class PersonalNumberTests
    {
        [Test]
        public void A_correct_number_should_be_valid()
        {
            PersonalNumber personalNumber = new PersonalNumber("800531-8996");
            Assert.That(personalNumber.IsValid);
        }

        [Test]
        public void Should_be_able_to_get_controll_number()
        {
            PersonalNumber personalNumber = new PersonalNumber("800531-8996");

            int checkNumber = personalNumber.GetControllNumber();

            checkNumber.Should().Be(6);
        }

        [Test]
        public void Should_be_able_to_get_array_of_numbers_from_personal_number()
        {
            IEnumerable<int> enumerable = TrimPersonalNumberStringToNumbers.Trim("800531-8996");
            enumerable.Should().BeEquivalentTo(new List<int> { 8, 0, 0, 5, 3, 1, 8, 9, 9 });
        }
    }
}
