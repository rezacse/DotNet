using System.Diagnostics.Contracts;
using InterviewCoding.BetterCoding.Builders.Machine.Contracts;
using InterviewCoding.BetterCoding.Models;

namespace InterviewCoding.BetterCoding.Builders.Machine.Interfaces
{
    [ContractClass(typeof(OwnedContracts))]
    public interface IOwned
    {
        IMachineBuilder OwnedBy(LegalEntity company);
    }
}