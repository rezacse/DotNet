using NUnit.Framework;
using Programming.LeetCode.TopInterviews;

namespace ProgrammingTests.LeetCode.Completed
{
    [TestFixture]
    public class FindKthLargestTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 2, 4)]
        [TestCase(new[] { 3, 2, 1, 5, 6, 4 }, 2, 5)]
        [TestCase(new[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4, 4)]
        [TestCase(new[] { 2, 1 }, 1, 2)]
        public void FindKthLargest_WhenCalled_ReturnExpected(int[] nums, int k, int expected)
        {
            var helper = new FindKthLargestSolution();

            var result = helper.FindKthLargest(nums, k);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
