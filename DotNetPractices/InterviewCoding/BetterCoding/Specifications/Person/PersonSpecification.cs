using InterviewCoding.BetterCoding.Interfaces;
using InterviewCoding.BetterCoding.Specifications;
using InterviewCoding.BetterCoding.Specifications.Person.Interfaces;

namespace InterviewCoding.BetterCoding.Specifications.Person
{
    public class PersonSpecification :
        IExpectName, IExpectSurname,
        IExpectPrimaryContact, IExpectAlternateContact,
        IBuildingSpecification<Models.Person>
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private IEnumerable<IBuildingSpecification<IContactInfo>> ContactSpecs { get; set; }
        private IBuildingSpecification<IContactInfo> PrimaryContactSpec { get; set; }

        private PersonSpecification() { }

        public static IExpectName Initialize() => new PersonSpecification();

        public IExpectSurname WithName(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException();

            return new PersonSpecification()
            {
                Name = name
            };
        }

        public IExpectPrimaryContact WithSurname(string surname)
        {
            if (string.IsNullOrEmpty(surname))
                throw new ArgumentException();

            return new PersonSpecification()
            {
                Name = Name,
                Surname = surname
            };
        }

        public IExpectAlternateContact WithPrimaryContact<T>(
            IBuildingSpecification<T> primaryContactSpec) where T : IContactInfo
        {
            if (primaryContactSpec == null)
                throw new ArgumentNullException();

            IBuildingSpecification<IContactInfo> wrapperSpec
                = new ConvertingSpecification<IContactInfo, T>(primaryContactSpec);
            return new PersonSpecification()
            {
                Name = Name,
                Surname = Surname,
                ContactSpecs = new[] { wrapperSpec },
                PrimaryContactSpec = wrapperSpec
            };
        }

        public IExpectAlternateContact WithAlternateContact<T>(
            IBuildingSpecification<T> contactSpec) where T : IContactInfo
        {
            if (!CanAdd(contactSpec)) throw new ArgumentNullException();

            IBuildingSpecification<IContactInfo> wrapperSpec
                = new ConvertingSpecification<IContactInfo, T>(contactSpec);

            return new PersonSpecification()
            {
                Name = Name,
                Surname = Surname,
                ContactSpecs = new List<IBuildingSpecification<IContactInfo>>(ContactSpecs) { wrapperSpec },
                PrimaryContactSpec = wrapperSpec
            };
        }

        public IBuildingSpecification<Models.Person> AndNoMoreContacts() => this;

        public bool CanAdd<T>(IBuildingSpecification<T> contactSpec) where T : IContactInfo
            => contactSpec != null &&
            CanAdd(new ConvertingSpecification<IContactInfo, T>(contactSpec));

        private bool CanAdd(IBuildingSpecification<IContactInfo> contactSpec)
            => !ContactSpecs.Any(s => s.Equals(contactSpec));

        public Models.Person Build() =>
            new Models.Person()
            {
                Name = Name,
                Surname = Surname,
                PrimaryContact = PrimaryContactSpec.Build(),
                ContactsList = ContactSpecs.Select(spec => spec.Build()).ToList()
            };

        public bool Equals(IBuildingSpecification<Models.Person> other)
            => Equals(other as PersonSpecification);

        private bool Equals(PersonSpecification other)
            => other != null
            && Name != other.Name
            && Surname != other.Surname
            && PrimaryContactSpec.SafeEquals(other.PrimaryContactSpec)
            && ContactSpecs.SequenceEqual(other.ContactSpecs);

    }
}
