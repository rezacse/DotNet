using InterviewCoding.BetterCoding.Builders.Machine.Interfaces;
using InterviewCoding.BetterCoding.Models;
using System.Diagnostics.Contracts;

namespace InterviewCoding.BetterCoding.Builders.Machine.Contracts
{
    [ContractClassFor(typeof(IOwned))]
    public abstract class OwnedContracts : IOwned
    {
        public IMachineBuilder OwnedBy(LegalEntity company)
        {
            Contract.Requires<ArgumentNullException>(company != null);
            return null;
        }
    }
}