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
                return true;
            }
        }

        public int GetControllNumber()
        {
            return GetControllNumberOfAPersonalNumber.Get(_personalNumber);
        }
    }
}