using InterviewCoding.BetterCoding.Interfaces;
using System.Diagnostics.Contracts;

namespace InterviewCoding.BetterCoding.Models
{
    public class LegalEntity
    {

        public string CompanyName { get; set; }
        public EmailAddress EmailAddress { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
        public IList<IContactInfo> OtherContacts { get; set; } = new List<IContactInfo>();

        public LegalEntity()
        {

        }

        public LegalEntity(string companyName, EmailAddress emailAddress, PhoneNumber phoneNumber)
        {
            Contract.Requires<ArgumentException>(!string.IsNullOrEmpty(companyName));
            Contract.Requires<ArgumentNullException>(emailAddress != null);
            Contract.Requires<ArgumentNullException>(phoneNumber != null);

            CompanyName = companyName;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
        }

        public void SetEmailAddress(EmailAddress emailAddress)
        {
            Contract.Requires<ArgumentNullException>(emailAddress != null);
            EmailAddress = emailAddress;
        }

        public void SetPhoneNumber(PhoneNumber phoneNumber)
        {
            Contract.Requires<ArgumentNullException>(phoneNumber != null);
            PhoneNumber = phoneNumber;
        }

        public void Add(IContactInfo alternateContact)
        {
            Contract.Requires<ArgumentNullException>(alternateContact != null);
            Contract.Requires<ArgumentException>(!Contains(alternateContact));

            OtherContacts.Add(alternateContact);
        }

        [Pure]
        public bool Contains(IContactInfo contact)
        {
            return
                EmailAddress.Equals(contact) ||
                PhoneNumber.Equals(contact) ||
                OtherContacts.Contains(contact);
        }


        public override string ToString() =>
            $"{CompanyName} {EmailAddress} {PhoneNumber} [{OtherContactsToString()}]";

        private string OtherContactsToString() =>
            string.Join(", ", OtherContactsToStringArray());

        private string[] OtherContactsToStringArray() =>
            OtherContacts.Select(contact => contact.ToString()).ToArray();

    }
}
