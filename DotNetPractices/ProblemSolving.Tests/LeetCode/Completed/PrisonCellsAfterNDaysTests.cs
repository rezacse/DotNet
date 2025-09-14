using NUnit.Framework;
using Programming.LeetCode.July;

namespace ProgrammingTests.LeetCode.Completed
{
    [TestFixture]
    public class PrisonCellsAfterNDaysTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new[] { 0, 1, 0, 1, 1, 0, 0, 1 }, 6, new[] { 0, 0, 1, 0, 1, 1, 0, 0 })]
        [TestCase(new[] { 0, 1, 0, 1, 1, 0, 0, 1 }, 7, new[] { 0, 0, 1, 1, 0, 0, 0, 0 })]
        [TestCase(new[] { 0, 1, 0, 1, 1, 0, 0, 1 }, 8, new[] { 0, 0, 0, 0, 0, 1, 1, 0 })]
        [TestCase(new[] { 0, 1, 0, 1, 1, 0, 0, 1 }, 13, new[] { 0, 0, 1, 1, 0, 1, 0, 0 })]
        [TestCase(new[] { 0, 1, 0, 1, 1, 0, 0, 1 }, 14, new[] { 0, 0, 0, 0, 1, 1, 0, 0 })]
        [TestCase(new[] { 0, 1, 0, 1, 1, 0, 0, 1 }, 15, new[] { 0, 1, 1, 0, 0, 0, 0, 0 })]
        [TestCase(new[] { 0, 1, 0, 1, 1, 0, 0, 1 }, 16, new[] { 0, 0, 0, 0, 1, 1, 1, 0 })]

        [TestCase(new[] { 1, 0, 0, 1, 0, 0, 1, 0 }, 6, new[] { 0, 0, 1, 1, 1, 1, 1, 0 })]
        [TestCase(new[] { 1, 0, 0, 1, 0, 0, 1, 0 }, 7, new[] { 0, 0, 0, 1, 1, 1, 0, 0 })]
        [TestCase(new[] { 1, 0, 0, 1, 0, 0, 1, 0 }, 8, new[] { 0, 1, 0, 0, 1, 0, 0, 0 })]
        [TestCase(new[] { 1, 0, 0, 1, 0, 0, 1, 0 }, 13, new[] { 0, 1, 1, 1, 1, 1, 0, 0 })]
        [TestCase(new[] { 1, 0, 0, 1, 0, 0, 1, 0 }, 14, new[] { 0, 0, 1, 1, 1, 0, 0, 0 })]
        [TestCase(new[] { 1, 0, 0, 1, 0, 0, 1, 0 }, 15, new[] { 0, 0, 0, 1, 0, 0, 1, 0 })]
        [TestCase(new[] { 1, 0, 0, 1, 0, 0, 1, 0 }, 1000000000, new[] { 0, 0, 1, 1, 1, 1, 1, 0 })]
        [TestCase(new[] { 0, 0, 0, 1, 1, 0, 1, 0 }, 574, new[] { 0, 0, 0, 1, 1, 0, 1, 0 })]

        //[1,0,0,1,0,0,1,0]
        public void GetMax_WhenCalled_ReturnMaxSubarraySum(
            int[] cells, int days, int[] expected)
        {
            var helper = new PrisonCellsAfterNDays();

            var result = helper.GetAfterNDays(cells, days);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
