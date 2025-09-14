using NUnit.Framework;
using Programming.LeetCode;

namespace ProgrammingTests.LeetCode.Completed
{
    [TestFixture]
    public class MaximumSubarrayTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
        [TestCase(new[] { 1, 2, 3 }, 6)]
        [TestCase(new[] { -1, -2, -3 }, -1)]
        [TestCase(new[] { -2, 1, -3, 4, -1, 2, 1, 0, 4 }, 10)]
        [TestCase(new[] { -2, 1, -3, 4, -5, 2, 1, 0, 4 }, 7)]
        [TestCase(new[] { -2, 1, -3, 4 }, 4)]
        [TestCase(new[] { 5, -3, 5 }, 7)]
        public void GetMax_WhenCalled_ReturnMaxSubarraySum(int[] nums, int expected)
        {
            var helper = new MaximumSubarray();

            var result = helper.GetMax(nums);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}