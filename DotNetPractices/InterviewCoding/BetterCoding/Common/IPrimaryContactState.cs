using InterviewCoding.BetterCoding.Interfaces;

namespace InterviewCoding.BetterCoding.Common
{
    internal interface IPrimaryContactState
    {
        IPrimaryContactState Set(IContactInfo contact);
        IContactInfo Get();
    }
}
