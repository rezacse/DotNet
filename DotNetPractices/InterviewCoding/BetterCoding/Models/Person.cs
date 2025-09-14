using InterviewCoding.BetterCoding.Interfaces;

namespace InterviewCoding.BetterCoding.Models
{
    public class Person : IUser
    {
        public string Name { get; internal set; }
        public string Surname { get; internal set; }
        public IEnumerable<IContactInfo> Contacts => ContactsList;
        public IContactInfo PrimaryContact { get; internal set; }

        internal IList<IContactInfo> ContactsList { get; set; } = new List<IContactInfo>();

        internal Person() { }


        public void SetIdentify(IUserIdentity identity)
        {
        }

        public bool CanAcceptIdentity(IUserIdentity identity)
            => identity is IdentityCard;
        private string AllContactsLabel =>
            string.Join(", ", AllContactLabels.ToArray());


        private IEnumerable<string> AllContactLabels =>
            Contacts.Select(GetLabelFor);

        private string GetLabelFor(IContactInfo contact) =>
            $"{GetUiMarkFor(contact)}{contact}";

        private string GetUiMarkFor(IContactInfo contact) =>
            IsPrimary(contact) ? "*" : string.Empty;

        private bool IsPrimary(IContactInfo contact) => contact.Equals(PrimaryContact);

        public override string ToString() =>
                    $"{Name} {Surname} [{AllContactsLabel}]";

        public void Add(IContactInfo contact)
        {
            throw new NotImplementedException();
        }

        public void SetPrimaryContact(IContactInfo contact)
        {
            throw new NotImplementedException();
        }
    }
}
