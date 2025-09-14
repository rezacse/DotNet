using InterviewCoding.BetterCoding.Validation;

namespace InterviewCoding.BetterCoding.Validation.Infrastructure
{
    public class Composite<T> : Specification<T>
    {
        public Composite(Func<IEnumerable<bool>, bool> compositionFunction,
            params Specification<T>[] subspecification)
        {
            CompositionFunction = compositionFunction;
            Subspecification = subspecification;
        }

        public Func<IEnumerable<bool>, bool> CompositionFunction { get; }
        public Specification<T>[] Subspecification { get; }

        public override bool IsSatisfiedBy(T obj)
            => CompositionFunction(Subspecification.Select(s => s.IsSatisfiedBy(obj)));
    }
}
