namespace InterviewCoding.BetterCoding.Common
{
    internal class NonEmptyString: INonEmptyStringState
    {
        private string _value;
        public NonEmptyString(string value)
        {
            if(string.IsNullOrEmpty(value)) throw new ArgumentNullException("value");

            _value = value;
        }

        public string Get() => _value;

        public INonEmptyStringState Set(string value)
            => new NonEmptyString(value);
    }
}
