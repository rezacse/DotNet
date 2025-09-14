using NUnit.Framework;
using Programming.LeetCode;

namespace ProgrammingTests.LeetCode.Completed
{
    [TestFixture]
    public class MoveZerosTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new[] { 1 }, new[] { 1 })]
        [TestCase(new[] { 0 }, new[] { 0 })]
        [TestCase(new[] { 0, 1 }, new[] { 1, 0 })]
        [TestCase(new[] { 1, 0 }, new[] { 1, 0 })]
        [TestCase(new[] { 0, 1, 0, 3, 5 }, new[] { 1, 3, 5, 0, 0 })]
        [TestCase(new[] { 0, 0, 1, 3, 5 }, new[] { 1, 3, 5, 0, 0 })]
        [TestCase(new[] { 1, 3, 5, 0, 0 }, new[] { 1, 3, 5, 0, 0 })]
        [TestCase(new[] { 1, 3, 0, 0, 5 }, new[] { 1, 3, 5, 0, 0 })]
        [TestCase(new[] { 0, 0, 0, 0, 5 }, new[] { 5, 0, 0, 0, 0 })]
        [TestCase(new[] { 5, 0, 0, 0, 0 }, new[] { 5, 0, 0, 0, 0 })]
        [TestCase(new[] { 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0 })]
        [TestCase(new[] { 1, 1, 1, 1, 1 }, new[] { 1, 1, 1, 1, 1 })]
        public void Move_WhenCalled_ShouldMoveAllZeroToLast(int[] num, int[] expected)
        {
            var helper = new MoveZeros();

            var result = helper.Move(num);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}