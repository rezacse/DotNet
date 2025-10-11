using ProblemSolving.LeetCode;

namespace ProblemSolving.Tests.LeetCode.Completed;

[TestFixture]
public class ReformatPhoneNumberTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase("123  45-67", "123-45-67")]
    [TestCase("123 456789", "123-456-789")]
    [TestCase("1234", "12-34")]
    [TestCase("1-2-3", "123")]
    [TestCase("12", "12")]
    public void Format_WhenValued_ReturnTrue(string input, string actual)
    {
        var helper = new ReformatPhoneNumber();
        var expected = helper.Format(input);

        Assert.That(expected, Is.EqualTo(actual));
    }

}
