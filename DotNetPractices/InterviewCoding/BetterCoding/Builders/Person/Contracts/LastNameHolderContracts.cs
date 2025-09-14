using System.Diagnostics.Contracts;
using InterviewCoding.BetterCoding.Builders.Person.Interfaces;

namespace InterviewCoding.BetterCoding.Builders.Person.Contracts
{
    [ContractClassFor(typeof(ILastNameHolder))]
    public abstract class LastNameHolderContracts : ILastNameHolder
    {
        public abstract bool IsValidLastName(string surname);

        public IPrimaryContactHolder WithLastName(string surname)
        {
            Contract.Requires(IsValidLastName(surname));
            return null;
        }
    }
}