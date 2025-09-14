using InterviewCoding.BetterCoding.Interfaces;
using InterviewCoding.BetterCoding.Specifications;

namespace InterviewCoding.BetterCoding.Specifications.LegalEntity.Interfaces
{
    public interface IExpectOtherContact
    {
        IExpectOtherContact WithOtherContact<T>(IBuildingSpecification<T> contactSpec)
            where T : IContactInfo;
        IBuildingSpecification<Models.LegalEntity> AndNoMoreContacts();
    }
}