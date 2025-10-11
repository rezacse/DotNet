using ProblemSolving.LeetCode.Completed;

namespace ProblemSolving.Tests.LeetCode.Completed
{
    [TestFixture]
    public class AddBinarysTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("0", "0", "0")]
        [TestCase("0", "1", "1")]
        [TestCase("1", "0", "1")]
        [TestCase("1", "1", "10")]
        [TestCase("11", "1", "100")]
        [TestCase("1010", "1011", "10101")]
        [TestCase("1111", "1111", "11110")]
        [TestCase("1111", "111", "10110")]
        [TestCase("100", "110010", "110110")]
        public void AddBinary_WhenCalled_ReturnExpected(string a, string b, string e)
        {
            var helper = new AddBinarys();

            var result = helper.AddBinary(a, b);

            Assert.That(result, Is.EqualTo(e));
        }
    }
}
