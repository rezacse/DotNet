namespace ProblemSolving.Tests.LeetCode.Completed;

[TestFixture]
public class ThreeSumTests
{

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(new int[] { 0, 2, 1, -6, 6, -7, 9, 1, 2, 0, 1 }, true)]
    [TestCase(new int[] { 0, 2, 1, -6, 6, 7, 9, -1, 2, 0, 1 }, false)]
    [TestCase(new int[] { 3, 3, 6, 5, -2, 2, 5, 1, -9, 4 }, true)]
    public void Is3SumEqual_WhenCalled_ReturnExpected(int[] a, bool e)
    {
        var helper = new ThreeSum();

        var result = helper.Is3SumEqual(a);

        Assert.That(result, Is.EqualTo(e));
    }
}

