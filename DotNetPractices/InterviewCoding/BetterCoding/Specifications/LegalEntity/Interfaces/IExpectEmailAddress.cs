using InterviewCoding.BetterCoding.Specifications;

namespace InterviewCoding.BetterCoding.Specifications.LegalEntity.Interfaces
{
    public interface IExpectEmailAddress
    {
        IExpectPhoneNumber WithEmailAddress(IBuildingSpecification<Models.EmailAddress> emailSpec);
    }
}