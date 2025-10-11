using ProblemSolving.LeetCode.InProgress;

namespace ProblemSolving.Tests.LeetCode;

[TestFixture]
public class RemoveDuplicateTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(new[] { 1, 1, 1, 2, 2, 3 }, 5, new[] { 1, 1, 2, 2, 3 })]
    [TestCase(new[] { 0, 1, 1, 1, 2, 2, 3 }, 6, new[] { 0, 1, 1, 2, 2, 3 })]
    [TestCase(new[] { 0, 1, 1, 1, 2, 2, 3, 4, 4, 4 }, 8, new[] { 0, 1, 1, 2, 2, 3, 4, 4 })]
    [TestCase(new[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 }, 7, new[] { 0, 0, 1, 1, 2, 3, 3 })]
    [TestCase(new[] { 1, 1, 1, 1, 2, 2, 3 }, 5, new[] { 1, 1, 2, 2, 3 })]
    [TestCase(new[] { 1, 1, 1, 1, 1, 2, 2, 3 }, 5, new[] { 1, 1, 2, 2, 3 })]
    public void SortedArrayII_WhenValued_ReturnExpected(int[] inputs, int l, int[] enums)
    {
        var helper = new RemoveDuplicate();
        var expected = helper.SortedArrayII(inputs);

        for (int i = 0; i < expected; i++)
        {
            Assert.That(enums[i], Is.EqualTo(inputs[i]));
        }

        Assert.That(expected, Is.EqualTo(l));
    }
}
