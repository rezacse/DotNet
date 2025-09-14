using InterviewCoding.BetterCoding.Builders.Person.Contracts;
using System.Diagnostics.Contracts;

namespace InterviewCoding.BetterCoding.Builders.Person.Interfaces
{
    [ContractClass(typeof(FirstNameHolderContracts))]
    public interface IFirstNameHolder
    {
        ILastNameHolder WithFirstName(string name);
        [Pure]
        bool IsValidFirstName(string name);
    }
}
