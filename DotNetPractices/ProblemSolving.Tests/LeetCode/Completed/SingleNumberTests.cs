using NUnit.Framework;
using Programming.LeetCode;

namespace ProgrammingTests.LeetCode.Completed
{
    [TestFixture]
    public class SingleNumberTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new[] { 1 }, 1)]
        [TestCase(new[] { 2, 2, 1 }, 1)]
        [TestCase(new[] { 4, 1, 2, 1, 2 }, 4)]
        [TestCase(new[] { 1, 2, 3, 1, 2, 3, 5 }, 5)]
        [TestCase(new[] { 1, 2, 3, 5, 2, 3, 1 }, 5)]
        [TestCase(new[] { -1, -2, 2, -1, 2 }, -2)]
        public void GetSingleNumber_WhenCalled_ReturnItemThatExistOneAtArray(int[] nums, int expected)
        {
            var helper = new SingleNumber();

            var result = helper.GetSingleNumber(nums);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}