using System.Diagnostics.Contracts;
using InterviewCoding.BetterCoding.Builders.Person.Contracts;
using InterviewCoding.BetterCoding.Interfaces;

namespace InterviewCoding.BetterCoding.Builders.Person.Interfaces
{
    [ContractClass(typeof(SecondaryContactHolderContracts))]
    public interface ISecondaryContactHolder : IContactHolder
    {
        ISecondaryContactHolder WithSecondaryContact(IContactInfo contact);
        IPersonBuilder AndNoMoreContacts();
    }
}