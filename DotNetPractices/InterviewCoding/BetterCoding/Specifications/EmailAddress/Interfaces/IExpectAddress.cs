using InterviewCoding.BetterCoding.Specifications;

namespace InterviewCoding.BetterCoding.Specifications.EmailAddress.Interfaces
{
    public interface IExpectAddress
    {
        IBuildingSpecification<Models.EmailAddress> WithAddress(string emailAddress);
    }
}
