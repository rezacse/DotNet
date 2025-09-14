using System.Diagnostics.Contracts;
using InterviewCoding.BetterCoding.Builders.Person.Contracts;
using InterviewCoding.BetterCoding.Interfaces;

namespace InterviewCoding.BetterCoding.Builders.Person.Interfaces
{
    [ContractClass(typeof(PrimaryContactHolderContracts))]
    public interface IPrimaryContactHolder : IContactHolder
    {
        ISecondaryContactHolder WithPrimaryContact(IContactInfo contact);
    }
}