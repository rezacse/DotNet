using InterviewCoding.BetterCoding.Factories.Interfaces;
using InterviewCoding.BetterCoding.Interfaces;
using InterviewCoding.BetterCoding.Models;

namespace InterviewCoding.BetterCoding.Factories.Person
{
    public class PersonFactory : IUserFactory
    {
        public IUser CreateUser(string name1, string name2)
        {
            Models.Person person = new Models.Person();
            person.Name = name1;
            person.Surname = name2;
            return person;
        }

        public IUserIdentity CreateIdentity()
        {
            return new IdentityCard();
        }
    }
}
