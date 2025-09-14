using InterviewCoding.BetterCoding.Interfaces;
using System.Diagnostics.Contracts;

namespace InterviewCoding.BetterCoding.Builders.Person.Interfaces
{
    public interface IContactHolder
    {
        [Pure]
        bool Contains(IContactInfo contact);
    }
}
