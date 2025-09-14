using InterviewCoding.Outputs;
using NUnit.Framework;

namespace InterviewCoding.Tests.Outputs
{
    [TestFixture]
    public class UtitilityHelperTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RunAsync_Test()
        {
            var obj = new OutputCheck();
            obj.RunAsync();
        }
    }
}
