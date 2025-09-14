using System.Diagnostics.Contracts;
using InterviewCoding.BetterCoding.Builders.Machine.Contracts;

namespace InterviewCoding.BetterCoding.Builders.Machine.Interfaces
{
    [ContractClass(typeof(ModelHolderContracts))]
    public interface IModelHolder
    {
        IOwned WithModel(string model);
    }
}