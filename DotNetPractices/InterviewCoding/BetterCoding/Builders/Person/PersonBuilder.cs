using InterviewCoding.BetterCoding.Builders.Person.Interfaces;
using InterviewCoding.BetterCoding.Interfaces;

namespace InterviewCoding.BetterCoding.Builders.Person
{
    public class PersonBuilder :
        IFirstNameHolder, ILastNameHolder, IPrimaryContactHolder,
        ISecondaryContactHolder, IPersonBuilder
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private IContactInfo PrimaryContact { get; set; }
        private IList<IContactInfo> Contacts { get; set; } = new List<IContactInfo>();

        public static IFirstNameHolder Person() => new PersonBuilder();

        public bool IsValidFirstName(string name) => !string.IsNullOrEmpty(FirstName);
        public ILastNameHolder WithFirstName(string name)
            => new PersonBuilder { FirstName = name };

        public bool IsValidLastName(string surname) => !string.IsNullOrEmpty(LastName);
        public IPrimaryContactHolder WithLastName(string surname)
            => new PersonBuilder
            {
                FirstName = FirstName,
                LastName = surname
            };

        public ISecondaryContactHolder WithPrimaryContact(IContactInfo contact)
            => new PersonBuilder
            {
                FirstName = FirstName,
                LastName = LastName,
                PrimaryContact = contact,
                Contacts = new List<IContactInfo>(Contacts) { contact },
            };

        public ISecondaryContactHolder WithSecondaryContact(IContactInfo contact)
            => new PersonBuilder
            {
                FirstName = FirstName,
                LastName = LastName,
                PrimaryContact = PrimaryContact,
                Contacts = new List<IContactInfo>(Contacts) { contact },
            };

        public IPersonBuilder AndNoMoreContacts() => this;

        public bool Contains(IContactInfo contact) => Contacts.Contains(contact);


        public Models.Person Build()
        {
            var person = new Models.Person();
            person.Name= FirstName;
            person.Surname= LastName;
            person.PrimaryContact= PrimaryContact;
            foreach (IContactInfo contact in Contacts)
                person.ContactsList.Add(contact);

            return person;

        }
    }
}
