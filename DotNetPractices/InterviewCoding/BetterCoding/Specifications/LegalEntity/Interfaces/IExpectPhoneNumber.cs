using InterviewCoding.BetterCoding.Specifications;

namespace InterviewCoding.BetterCoding.Specifications.LegalEntity.Interfaces
{
    public interface IExpectPhoneNumber
    {
        IExpectOtherContact WithPhoneNumber(IBuildingSpecification<Models.PhoneNumber> phoneSpec);
    }
}