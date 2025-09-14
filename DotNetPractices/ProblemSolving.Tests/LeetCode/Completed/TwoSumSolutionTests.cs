using NUnit.Framework;
using Programming.LeetCode.TopInterviews;

namespace ProgrammingTests.LeetCode.Completed
{
    [TestFixture]
    public class RomanToIntSolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("IX", 9)]
        [TestCase("XIII", 13)]
        [TestCase("MCMXCIV", 1994)]
        public void RomanToInt_WhenCalled_ReturnItemExpected(string roman, int expected)
        {
            var helper = new RomanToIntSolution();

            var result = helper.RomanToInt(roman);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
