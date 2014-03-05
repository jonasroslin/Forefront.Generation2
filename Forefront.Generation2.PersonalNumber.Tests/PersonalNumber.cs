using System;
using System.Linq;

namespace Forefront.Generation2.PersonalNumber.Tests
{
    public class PersonalNumber
    {
        private readonly string _personalNumber;

        public PersonalNumber(string personalNumber)
        {
            _personalNumber = personalNumber;
        }

        public bool IsValid
        {
            get
            {
                //int controllNumber = GetControllNumber();
                //char last = _personalNumber[_personalNumber.Length - 1];
                //if(controllNumber == Convert.ToInt32(last.ToString()))
                return true;
            }
        }

        public int GetControllNumber()
        {
            return GetControllNumberOfAPersonalNumber.Get(_personalNumber);
        }
    }
}