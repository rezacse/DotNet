using NUnit.Framework;
using Programming.LeetCode.TopInterviews;

namespace ProgrammingTests.LeetCode.Completed
{
    [TestFixture]
    public class LongestNoRepeatCharacterSubStringTests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        [TestCase("", 0)]
        [TestCase("aaaa", 1)]
        [TestCase("abcabcbb", 3)]
        [TestCase("pwwkew", 3)]
        [TestCase("yabxad", 4)]
        public void TwoSum_WhenCalled_ReturnItemExpected(string s, int expected)
        {
            var helper = new LongestNoRepeatCharacterSubString();

            var result = helper.LengthOfLongestSubstring(s);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
