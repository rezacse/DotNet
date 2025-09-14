using NUnit.Framework;
using Programming.LeetCode;

namespace ProgrammingTests.LeetCode.Completed
{
    [TestFixture]
    public class BestTimeToBuyTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new[] { 7, 1, 5, 3, 6, 4 }, 7)]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 4)]
        [TestCase(new[] { 7, 6, 4, 3, 1 }, 0)]
        [TestCase(new[] { 0 }, 0)]
        [TestCase(new[] { 1, 1, 1, 1 }, 0)]
        [TestCase(new[] { 5, 4, 3, 2, 1 }, 0)]
        [TestCase(new[] { 1, 4, 7, 9 }, 8)]
        [TestCase(new int[] { }, 0)]
        public void CalculateProfit_WhenCalled_ReturnMaxProfit(int[] prices, int profit)
        {
            var helper = new BestTimeToBuy();

            var result = helper.CalculateProfit(prices);

            Assert.That(result, Is.EqualTo(profit));
        }
    }
}