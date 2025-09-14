using InterviewCoding.BetterCoding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCoding.BetterCoding.Validation.Infrastructure
{
    public class Transform<T> : Specification<T>
    {
        public Transform(Func<bool, bool> transformation, Specification<T> specification)
        {
            Transformation = transformation;
            Subspecification = specification;
        }

        public Func<bool, bool> Transformation { get; }
        public Specification<T> Subspecification { get; }

        public override bool IsSatisfiedBy(T obj) =>
            Transformation(Subspecification.IsSatisfiedBy(obj));

    }
}
