using InterviewCoding.BetterCoding.Interfaces;
using InterviewCoding.BetterCoding.Specifications;
using InterviewCoding.BetterCoding.Specifications.LegalEntity.Interfaces;

namespace InterviewCoding.BetterCoding.Specifications.LegalEntity
{
    public class LegalEntitySpecification :
        IExpectCompanyName, IExpectEmailAddress,
        IExpectPhoneNumber, IExpectOtherContact,
        IBuildingSpecification<Models.LegalEntity>
    {
        private string CompanyName { get; set; }
        private IBuildingSpecification<Models.EmailAddress> EmailAddressSpec { get; set; }
        private IBuildingSpecification<Models.PhoneNumber> PhoneNumberSpec { get; set; }

        private IList<IBuildingSpecification<IContactInfo>> OtherContactSpecs { get; set; }
            = new List<IBuildingSpecification<IContactInfo>>();

        private LegalEntitySpecification() { }

        public static IExpectCompanyName Initialize() => new LegalEntitySpecification();

        public IExpectEmailAddress WithCompanyName(string companyName)
        {
            if (string.IsNullOrEmpty(companyName))
                throw new ArgumentException();

            return new LegalEntitySpecification()
            {
                CompanyName = companyName
            };
        }

        public IExpectPhoneNumber WithEmailAddress(IBuildingSpecification<Models.EmailAddress> emailSpec)
        {
            if (emailSpec == null)
                throw new ArgumentNullException();

            return new LegalEntitySpecification()
            {
                CompanyName = CompanyName,
                EmailAddressSpec = emailSpec
            };
        }

        public IExpectOtherContact WithPhoneNumber(IBuildingSpecification<Models.PhoneNumber> phoneSpec)
        {
            if (phoneSpec == null)
                throw new ArgumentNullException();

            return new LegalEntitySpecification()
            {
                CompanyName = CompanyName,
                EmailAddressSpec = EmailAddressSpec,
                PhoneNumberSpec = phoneSpec
            };
        }

        public IExpectOtherContact WithOtherContact<T>(IBuildingSpecification<T> contactSpec)
            where T : IContactInfo
        {
            if (contactSpec == null)
                throw new ArgumentNullException();

            IBuildingSpecification<IContactInfo> wrapperSpec
                = new ConvertingSpecification<IContactInfo, T>(contactSpec);
            return new LegalEntitySpecification()
            {
                CompanyName = CompanyName,
                EmailAddressSpec = EmailAddressSpec,
                PhoneNumberSpec = PhoneNumberSpec,
                OtherContactSpecs = new List<IBuildingSpecification<IContactInfo>>(OtherContactSpecs) { wrapperSpec }
            };
        }

        public IBuildingSpecification<Models.LegalEntity> AndNoMoreContacts() => this;

        public Models.LegalEntity Build() =>
            new Models.LegalEntity()
            {
                CompanyName = CompanyName,
                EmailAddress = EmailAddressSpec.Build(),
                PhoneNumber = PhoneNumberSpec.Build(),
                OtherContacts = OtherContactSpecs.Select(spec => spec.Build()).ToList()
            };

        public bool Equals(IBuildingSpecification<Models.LegalEntity> other) =>
            Equals(other as LegalEntitySpecification);

        private bool Equals(LegalEntitySpecification other) =>
            other != null &&
            CompanyName == other.CompanyName &&
            EmailAddressSpec.SafeEquals(other.EmailAddressSpec) &&
            PhoneNumberSpec.SafeEquals(other.PhoneNumberSpec) &&
            OtherContactSpecs.SequenceEqual(other.OtherContactSpecs);
    }
}
