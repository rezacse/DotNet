using InterviewCoding.BetterCoding.Validation;

namespace InterviewCoding.BetterCoding.Validation.Infrastructure
{
    public class NotNull<T> : Specification<T>
    {
        public override bool IsSatisfiedBy(T obj)
            => !ReferenceEquals(obj, null);
    }
}
