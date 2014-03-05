using System;
using System.Collections.Generic;
using System.Linq;
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
            string orginal = "800531-899";
            int x = 6;

            orginal = String.Format("{0}{1}", orginal, x);

            List<int> myNumbers = TrimPersonalNumberStringToNumbers.Trim("800531-8996");
            List<int> results = new List<int>();

            for(int i = 0; i < myNumbers.Count; i++)
            {
                int myNumber;
                if (i%2 == 0)
                {
                    myNumber = myNumbers[i]* 2;
                }
                else
                {
                    myNumber = myNumbers[i];
                }

                if (myNumber >= 10)
                {
                    int tiotal = myNumber / 10;
                    int ental = myNumber % 10;
                   
                    results.Add(tiotal);
                    results.Add(ental);
                }
                else
                {
                    results.Add(myNumber);
                }
               
            }


            myNumbers.Should().BeEquivalentTo(new List<int> { 8, 0, 0, 5, 3, 1, 8, 9, 9 });
        }
    }

    [TestFixture]
    public class Foo
    {
        [Test]
        public void Bar()
        {
            string number = "800531-8996";

            List<int> trim = TrimMyString.Trim(number);
            var ints = new List<int>{8,0,0,5,3,1,8,9,9,6};


            Assert.That(trim == ints);
        }
    }

    public static class TrimMyString
    {
        public static List<int> Trim(string input)
        {
            var ints = new List<int>();

            return ints;
        }
    }

}


