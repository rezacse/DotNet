using InterviewCoding.BetterCoding.Specifications;

namespace InterviewCoding.BetterCoding.Specifications.Machine.Interfaces
{
    public interface IExpectOwner
    {
        IBuildingSpecification<Models.Machine> OwnedBy(IBuildingSpecification<Models.LegalEntity> ownerSpec);
    }
}