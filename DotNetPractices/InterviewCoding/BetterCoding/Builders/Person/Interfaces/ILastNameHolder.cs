using InterviewCoding.BetterCoding.Builders.Person.Contracts;
using System.Diagnostics.Contracts;

namespace InterviewCoding.BetterCoding.Builders.Person.Interfaces
{
    [ContractClass(typeof(LastNameHolderContracts))]
    public interface ILastNameHolder
    {
        IPrimaryContactHolder WithLastName(string surname);
        [Pure]
        bool IsValidLastName(string surname);
    }
}