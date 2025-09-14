using InterviewCoding.BetterCoding.Specifications;

namespace InterviewCoding.BetterCoding.Specifications.PhoneNumber.Interfaces
{
    public interface IExpectNumber
    {
        IBuildingSpecification<Models.PhoneNumber> WithNumber(int number);
    }
}