using InterviewCoding.BetterCoding.Specifications;

namespace InterviewCoding.BetterCoding.Specifications.Machine.Interfaces
{
    public interface IExpectProducer
    {
        IExpectModel ProducedBy(IBuildingSpecification<Models.Producer> producerSpec);
    }
}