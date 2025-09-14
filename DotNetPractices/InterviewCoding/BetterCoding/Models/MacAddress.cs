using InterviewCoding.BetterCoding.Interfaces;

namespace InterviewCoding.BetterCoding.Models
{
    public class MacAddress : IUserIdentity
    {
        public string NicPart { get; set; }
    }
}
