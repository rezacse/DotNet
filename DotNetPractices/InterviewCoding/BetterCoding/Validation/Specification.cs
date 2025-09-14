using InterviewCoding.BetterCoding.Validation.Infrastructure;

namespace InterviewCoding.BetterCoding.Validation
{
    public abstract class Specification<T>
    {
        public abstract bool IsSatisfiedBy(T obj);

        public Specification<T> And(Specification<T> other)
            => new Composite<T>(r => r.All(res => res == true), this, other);
        public Specification<T> Or(Specification<T> other)
            => new Composite<T>(r => r.Any(res => res == true), this, other);
        public Specification<T> Not()
            => new Transform<T>(r => r, this);
    }
}
