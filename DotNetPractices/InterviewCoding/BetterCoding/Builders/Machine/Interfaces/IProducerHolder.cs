using System.Diagnostics.Contracts;
using InterviewCoding.BetterCoding.Builders.Machine.Contracts;
using InterviewCoding.BetterCoding.Models;

namespace InterviewCoding.BetterCoding.Builders.Machine.Interfaces
{
    [ContractClass(typeof(ProducerHolderContracts))]
    public interface IProducerHolder
    {
        IModelHolder WithProducer(Producer producer);
    }
}
