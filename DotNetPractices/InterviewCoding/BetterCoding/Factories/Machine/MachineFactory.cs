using InterviewCoding.BetterCoding.Factories.Interfaces;
using InterviewCoding.BetterCoding.Interfaces;
using InterviewCoding.BetterCoding.Models;

namespace InterviewCoding.BetterCoding.Factories.Machine
{
    public class MachineFactory : IUserFactory
    {
        private Dictionary<string, Producer> NameToProducer { get; }

        public MachineFactory(Dictionary<string, Producer> nameToProducer)
        {
            if (nameToProducer == null)
                throw new ArgumentNullException();
            NameToProducer = nameToProducer;
        }

        private Producer GetProducer(string name)
        {
            Producer producer;
            if (!NameToProducer.TryGetValue(name, out producer))
                throw new ArgumentException();
            return producer;
        }

        public IUser CreateUser(string name1, string name2)
        {
            Producer producer = GetProducer(name1);
            LegalEntity owner =
                new LegalEntity("Big Co.", new EmailAddress("big@co"), new PhoneNumber(1, 2, 3));

            return new Models.Machine(producer, name2, owner);

        }

        public IUserIdentity CreateIdentity()
        {
            return new MacAddress();
        }
    }
}
