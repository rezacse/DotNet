using NUnit.Framework;
using Programming.LeetCode.July;

namespace ProgrammingTests.LeetCode.Completed
{
    [TestFixture]
    public class UglyNumber2Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 4)]
        [TestCase(5, 5)]
        [TestCase(6, 6)]
        [TestCase(7, 8)]
        [TestCase(8, 9)]
        [TestCase(9, 10)]
        [TestCase(10, 12)]
        [TestCase(11, 15)]
        [TestCase(12, 16)]

        [TestCase(18, 30)]
        [TestCase(110, 2048)]
        [TestCase(555, 1600000)]
        [TestCase(1100, 97200000)]
        [TestCase(1690, 2123366400)]
        public void GetNthUglyNumber_WhenCalled_ReturnNthUglyNumber(int num, int u)
        {
            var helper = new UglyNumber2();

            var result = helper.GetNthUglyNumber(num);

            Assert.That(result, Is.EqualTo(u));
        }
    }
}
