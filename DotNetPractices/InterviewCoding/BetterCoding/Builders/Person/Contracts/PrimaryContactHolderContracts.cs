using System.Diagnostics.Contracts;
using InterviewCoding.BetterCoding.Builders.Person.Interfaces;
using InterviewCoding.BetterCoding.Interfaces;

namespace InterviewCoding.BetterCoding.Builders.Person.Contracts
{
    [ContractClassFor(typeof(IPrimaryContactHolder))]
    public abstract class PrimaryContactHolderContracts : IPrimaryContactHolder
    {
        public ISecondaryContactHolder WithPrimaryContact(IContactInfo contact)
        {
            Contract.Requires(contact != null);
            Contract.Requires(!Contains(contact));
            return null;
        }

        public abstract bool Contains(IContactInfo contact);
    }
}