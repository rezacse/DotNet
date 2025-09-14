using InterviewCoding.BetterCoding.Interfaces;
using System.Globalization;

namespace InterviewCoding.BetterCoding.Models
{
    public class EmailAddress : IContactInfo
    {
        public string Address { get; set; }
        public EmailAddress()
        {

        }
        public EmailAddress(string address)
        {
            if(string.IsNullOrEmpty(address))
                throw new ArgumentNullException("address");
            Address = address;  
        }

        public override int GetHashCode() => Address.ToLower().GetHashCode();

        public override bool Equals(object? obj)
        {
            EmailAddress? email = obj as EmailAddress;
            if(email == null) return false;

            return string.Compare(Address, email.Address
                , true, CultureInfo.InvariantCulture) == 0;
        }

        public override string ToString() => $"{Address}";
        
    }
}
