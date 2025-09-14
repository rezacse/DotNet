using InterviewCoding.BetterCoding.Interfaces;
using InterviewCoding.BetterCoding.Specifications;

namespace InterviewCoding.BetterCoding.Specifications.Person.Interfaces
{
    public interface IExpectAlternateContact
    {
        IExpectAlternateContact WithAlternateContact<T>(IBuildingSpecification<T> contactSpec)
            where T : IContactInfo;
        bool CanAdd<T>(IBuildingSpecification<T> contactSpec) where T: IContactInfo;
        IBuildingSpecification<Models.Person> AndNoMoreContacts();
    }
}