using NUnit.Framework;
using Programming.LeetCode.July;

namespace ProgrammingTests.LeetCode.Completed
{
    [TestFixture]
    public class HammingDistanceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1, 4, 2)]
        [TestCase(1, 1, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(1, 6, 3)]
        [TestCase(0, 15, 4)]
        public void GetDistance_WhenCalled_ReturnDistance(int x, int y, int d)
        {
            var helper = new HammingDistance();

            var result = helper.GetDistance(x, y);

            Assert.That(result, Is.EqualTo(d));
        }
    }
}
