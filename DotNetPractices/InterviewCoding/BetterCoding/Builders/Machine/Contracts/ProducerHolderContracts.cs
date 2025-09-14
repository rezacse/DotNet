using System;
using System.Diagnostics.Contracts;
using InterviewCoding.BetterCoding.Builders.Machine.Interfaces;
using InterviewCoding.BetterCoding.Models;

namespace InterviewCoding.BetterCoding.Builders.Machine.Contracts
{
    [ContractClassFor(typeof(IProducerHolder))]
    public abstract class ProducerHolderContracts : IProducerHolder
    {
        public IModelHolder WithProducer(Producer producer)
        {
            Contract.Requires<ArgumentNullException>(producer != null);
            return null;
        }
    }
}