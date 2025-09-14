using InterviewCoding.BetterCoding.Interfaces;
using System.Diagnostics.Contracts;

namespace InterviewCoding.BetterCoding.Models
{
    public class Machine : IUser
    {
        public Producer Producer { get; set; }
        public string Model { get; set; }
        public LegalEntity Owner { get; set; }
        public IContactInfo PrimaryContact => Owner.EmailAddress;

        public Machine()
        {

        }
        public Machine(Producer producer, string model, LegalEntity owningBusiness)
        {
            Contract.Requires<ArgumentNullException>(producer != null);
            Contract.Requires<ArgumentException>(!string.IsNullOrEmpty(model));
            Contract.Requires<ArgumentNullException>(owningBusiness != null);

            Producer = producer;
            Model = model;
            Owner = owningBusiness;
        }

        public void SetIdentity(IUserIdentity identity)
        {
        }

        public bool CanAcceptIdentity(IUserIdentity identity)
        {
            return identity is MacAddress;
        }

        public void SetPrimaryContact(IContactInfo contact)
        {   // NOTE: It would be better to throw if contact is not email address
            // but that requires a new Boolean method like IsValidPrimaryContact
            // so that code contract can be implemented properly

            EmailAddress emailAddress = contact as EmailAddress;
            if (emailAddress == null)
                Owner.Add(contact);
            else
                Owner.SetEmailAddress(emailAddress);
        }

        public void Add(IContactInfo contact)
        {
            Owner.Add(contact);
        }

        public void SetIdentify(IUserIdentity identity)
        {
            throw new NotImplementedException();
        }

        public override string ToString() =>
            $"{Producer} {Model} owned by {Owner}";
    }
}
