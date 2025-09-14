using InterviewCoding.BetterCoding.Interfaces;
using InterviewCoding.BetterCoding.Specifications;

namespace InterviewCoding.BetterCoding.Specifications.Person.Interfaces
{
    public interface IExpectPrimaryContact
    {
        IExpectAlternateContact WithPrimaryContact<T>(IBuildingSpecification<T> primaryContactSpec)
            where T : IContactInfo;
    }
}