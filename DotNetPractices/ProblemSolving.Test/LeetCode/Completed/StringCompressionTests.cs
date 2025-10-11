using ProblemSolving.LeetCode;

namespace ProblemSolving.Tests.LeetCode.Completed;

[TestFixture]
public class StringCompressionTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase("abcde", "1a1b1c1d1e")]
    [TestCase("aaaaaaaaaaaaaabb", "9a5a2b")]
    [TestCase("a", "1a")]
    [TestCase("abcc", "1a1b2c")]
    [TestCase("aaaaaaaaabba", "9a2b1a")]
    [TestCase("aaaaaaaaaabba", "9a1a2b1a")]
    public void CompressStringII_WhenValued_ReturnTrue(string input, string actual)
    {
        var helper = new StringCompression();
        var expected = helper.CompressStringII(input);

        Assert.That(expected, Is.EqualTo(actual));
    }

    [Test]
    [TestCase(new char[] { }, 0)]
    [TestCase(new char[] { 'a' }, 1)]
    [TestCase(new char[] { 'a', 'b' }, 2)]
    [TestCase(new char[] { 'a', 'a' }, 2)]
    [TestCase(new char[] { 'a', 'a', 'b' }, 3)]
    [TestCase(new char[] { 'a', 'a', 'b', 'b' }, 4)]
    [TestCase(new char[] { 'a', 'b', 'c'}, 3)]
    [TestCase(new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' }, 6)]
    [TestCase(new char[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' }, 4)]
    public void CompressString_WhenValued_ReturnTrue(char[] input, int actual)
    {
        var helper = new StringCompression();
        var expected = helper.CompressString(input);

        Assert.That(expected, Is.EqualTo(actual));
    }
}
