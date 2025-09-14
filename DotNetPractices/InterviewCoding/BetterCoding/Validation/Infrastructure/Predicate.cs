using InterviewCoding.BetterCoding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCoding.BetterCoding.Validation.Infrastructure
{
    public class Predicate<T> : Specification<T>
    {
        public Func<T, bool> Delegate { get; }

        public Predicate(Func<T, bool> predicate)
        {
            Delegate = predicate;
        }

        public override bool IsSatisfiedBy(T obj)
            => Delegate(obj);

    }
}
