using NUnit.Framework;
using Programming.LeetCode.TopInterviews;

namespace ProgrammingTests.LeetCode.Completed
{
    [TestFixture]
    public class TopKFrequent
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        [TestCase(new[] { 1, 1, 1, 2, 2, 3 }, 2, new[] { 1, 2 })]
        [TestCase(new[] { 1 }, 1, new[] { 1 })]
        [TestCase(new[] { 5, 4, 4, 6, 6, 6 }, 2, new[] { 4, 6 })]
        public void ReverseString_WhenCalled_ReturnItemExpected(int[] nums, int k, int[] expected)
        {
            var helper = new TopKFrequentSolution();

            var values = helper.TopKFrequent(nums, k);

            Assert.That(values, Is.EquivalentTo(expected));
        }
    }
}
