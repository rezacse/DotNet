using NUnit.Framework;
using Programming.LeetCode.July;

namespace ProgrammingTests.LeetCode.Completed
{
    [TestFixture]
    public class SingleNumber3Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new[] { 1, 1, 2, 3 }, new[] { 2, 3 })]
        [TestCase(new[] { 1, 2, 6, 1 }, new[] { 2, 6 })]
        [TestCase(new[] { 3, 7, 2, 2 }, new[] { 3, 7 })]
        [TestCase(new[] { 1, 2, 1, 3, 2, 5 }, new[] { 3, 5 })]
        public void SingleNumber_WhenCalled_ReturnExpected(int[] a, int[] e)
        {
            var helper = new SingleNumber3();

            var result = helper.SingleNumber(a);

            Assert.That(result, Is.EquivalentTo(e));
        }
    }
}
