using NUnit.Framework;
using Programming.LeetCode.July;

namespace ProgrammingTests.LeetCode.Completed
{
    [TestFixture]
    public class ReverseWordTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(" a", "a")]
        [TestCase("a ", "a")]
        [TestCase("the sky is blue", "blue is sky the")]
        [TestCase("  hello world!", "world! hello")]
        [TestCase("  hello world!  ", "world! hello")]
        [TestCase("a good   example", "example good a")]
        [TestCase("a  good   example", "example good a")]
        [TestCase("  a  good   example   ", "example good a")]
        [TestCase("   a  good   example   ", "example good a")]
        public void ReverseWords_WhenCalled_ReturnExpected(string s, string rw)
        {
            var helper = new ReverseWord();

            var result = helper.ReverseWords(s);

            Assert.That(result, Is.EqualTo(rw));
        }
    }
}
