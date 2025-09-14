using InterviewCoding.BetterCoding.Specifications.Machine;
using InterviewCoding.BetterCoding.Specifications.Machine.Interfaces;
using InterviewCoding.BetterCoding.Specifications.Person;
using InterviewCoding.BetterCoding.Specifications.Person.Interfaces;

namespace InterviewCoding.BetterCoding.Specifications.User
{
    public static class UserSpecification
    {
        public static IExpectName ForPerson() => PersonSpecification.Initialize();
        public static IExpectProducer ForMachine() => MachineSpecification.Initialize();
    }
}
