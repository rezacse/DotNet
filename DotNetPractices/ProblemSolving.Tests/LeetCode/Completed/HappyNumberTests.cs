using NUnit.Framework;
using Programming.LeetCode;

namespace ProgrammingTests.LeetCode.Completed
{
    [TestFixture]
    public class HappyNumberTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1, true)]
        [TestCase(2, false)]
        [TestCase(3, false)]
        [TestCase(4, false)]
        [TestCase(5, false)]
        [TestCase(6, false)]
        [TestCase(7, true)]
        [TestCase(8, false)]
        [TestCase(9, false)]
        [TestCase(10, true)]
        [TestCase(19, true)]
        [TestCase(-19, true)]
        public void IsHappyNumber_WhenCalled_ReturnItemTrueOrInfinity(int num, bool isHappy)
        {
            var helper = new HappyNumber();

            var result = helper.IsHappy(num);

            Assert.That(result, Is.EqualTo(isHappy));
        }
    }
}