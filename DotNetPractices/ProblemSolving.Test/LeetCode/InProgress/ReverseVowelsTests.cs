using ProblemSolving.LeetCode;

namespace ProblemSolving.Tests.LeetCode.InProgress
{
    [TestFixture]
    public class ReverseVowelsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("hello", "holle")]
        [TestCase("leetcode", "leotcede")]
        [TestCase(" ", " ")]
        [TestCase("!!!", "!!!")]
        public void ReverseVowels_WhenCalled_ReturnExpected(string inputs, string expected)
        {
            var helper = new ReverseVowelsSolution();

            var result = helper.ReverseVowels(inputs);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
