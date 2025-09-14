using NUnit.Framework;
using Programming.LeetCode.TopInterviews;

namespace ProgrammingTests.LeetCode.Completed
{
    [TestFixture]
    public class TwoSumSolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        [TestCase(new[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [TestCase(new[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [TestCase(new[] { 3, 3 }, 6, new int[] { 0, 1 })]
        [TestCase(new[] { 2, 3, 8, 5 }, 7, new int[] { 0, 3 })]
        [TestCase(new[] { 2, 5, 6, 7 }, 13, new int[] { 2, 3 })]
        public void TwoSum_WhenCalled_ReturnItemExpected(int[] nums, int target, int[] expected)
        {
            var helper = new TwoSumSolution();

            var result = helper.TwoSum(nums, target);

            Assert.That(result, Is.EquivalentTo(expected));
        }
    }
}
