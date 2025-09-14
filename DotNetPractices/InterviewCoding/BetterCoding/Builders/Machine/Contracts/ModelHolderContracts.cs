using System;
using System.Diagnostics.Contracts;
using InterviewCoding.BetterCoding.Builders.Machine.Interfaces;

namespace InterviewCoding.BetterCoding.Builders.Machine.Contracts
{
    [ContractClassFor(typeof(IModelHolder))]
    public class ModelHolderContracts : IModelHolder
    {
        public IOwned WithModel(string model)
        {
            Contract.Requires<ArgumentException>(!string.IsNullOrEmpty(model));
            return null;
        }
    }
}