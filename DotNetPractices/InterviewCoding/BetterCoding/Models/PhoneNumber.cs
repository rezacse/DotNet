using InterviewCoding.BetterCoding.Interfaces;
using System.Diagnostics.Contracts;

namespace InterviewCoding.BetterCoding.Models
{
    public class PhoneNumber : IContactInfo
    {

        public int CountryCode { get; set; }
        public int AreaCode { get; set; }
        public int Number { get; set; }

        public PhoneNumber()
        {

        }

        public PhoneNumber(int countryCode, int areaCode, int number)
        {
             Contract.Requires<ArgumentException>(countryCode > 0);
            Contract.Requires<ArgumentException>(areaCode > 0);
            Contract.Requires<ArgumentException>(number > 0);

            CountryCode = countryCode;
            AreaCode = areaCode;
            Number = number;
        }

        public override string ToString() => $"+{CountryCode}({AreaCode}){Number}";

    }
}
