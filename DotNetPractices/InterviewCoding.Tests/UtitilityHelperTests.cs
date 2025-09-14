using NUnit.Framework;
using Practics;

namespace InterviewCoding.Tests
{
    [TestFixture]
    public class UtitilityHelperTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("875O876", new[] { 875, 876 })]
        [TestCase("877O878", new[] { 877, 878 })]
        public void BinaryTreeTilt_WhenUniValued_ReturnTrue(string input, int[] actual)
        {
            var helper = new UtitilityHelper();
            var expected = helper.ConvertToInt(input);

            Assert.Equals(expected, actual);
        }
    }
}
