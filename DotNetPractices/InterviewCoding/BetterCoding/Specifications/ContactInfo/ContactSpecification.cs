using InterviewCoding.BetterCoding.Specifications;
using InterviewCoding.BetterCoding.Specifications.EmailAddress;
using InterviewCoding.BetterCoding.Specifications.PhoneNumber;
using InterviewCoding.BetterCoding.Specifications.PhoneNumber.Interfaces;

namespace InterviewCoding.BetterCoding.Specifications.ContactInfo
{
    public static class ContactSpecification
    {
        public static IBuildingSpecification<Models.EmailAddress> ForEmailAddress(string emailAddress) =>
            EmailAddressSpecification.Initialize().WithAddress(emailAddress);

        public static IExpectCountryCode ForPhoneNumber() =>
            PhoneNumberSpecification.Initialize();
    }
}
