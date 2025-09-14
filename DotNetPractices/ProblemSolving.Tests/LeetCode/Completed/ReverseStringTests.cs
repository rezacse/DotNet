using NUnit.Framework;
using Programming.LeetCode.TopInterviews;

namespace ProgrammingTests.LeetCode.Completed
{
    [TestFixture]
    public class ReverseStringTests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        [TestCase(new[] { 'h', 'e', 'l', 'l', 'o' }, new[] { 'o', 'l', 'l', 'e', 'h' })]
        [TestCase(new[] { 'H', 'a', 'n', 'n', 'a', 'h' }, new[] { 'h', 'a', 'n', 'n', 'a', 'H' })]
        public void ReverseString_WhenCalled_ReturnItemExpected(char[] nums, char[] expected)
        {
            var helper = new ReverseStringSolution();

            helper.ReverseString(nums);

            Assert.That(nums, Is.EqualTo(expected));
        }
    }
}
