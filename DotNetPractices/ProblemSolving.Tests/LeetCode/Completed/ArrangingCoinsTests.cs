using NUnit.Framework;
using Programming.LeetCode.July;

namespace ProgrammingTests.LeetCode.Completed
{
    [TestFixture]
    public class ArrangingCoinsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(3, 2)]
        [TestCase(5, 2)]
        [TestCase(8, 3)]
        public void GetNoOfStairs_WhenCalled_ReturnNoOfStairs(int num, int s)
        {
            var helper = new ArrangingCoins();

            var result = helper.GetNoOfStairs(num);

            Assert.That(result, Is.EqualTo(s));
        }
    }
}