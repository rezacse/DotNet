namespace InterviewCoding.BetterCoding.Interfaces
{
    public interface IUser
    {
        void SetIdentify(IUserIdentity identity);
        bool CanAcceptIdentity(IUserIdentity identity);
        IContactInfo PrimaryContact { get; }
        void Add(IContactInfo contact);
        void SetPrimaryContact(IContactInfo contact);
    }
}
