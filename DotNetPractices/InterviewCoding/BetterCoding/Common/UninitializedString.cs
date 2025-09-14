namespace InterviewCoding.BetterCoding.Common
{
    internal class UninitializedString : INonEmptyStringState
    {
        public string Get()
        {
            throw new NotImplementedException();
        }

        public INonEmptyStringState Set(string value)
            => new NonEmptyString(value);
    }
}
