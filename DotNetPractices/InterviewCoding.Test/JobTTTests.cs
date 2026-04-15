namespace InterviewCoding.Tests;

[TestFixture]
public class JobTTTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(new[] { 2, 1, 2, 1, 2 }, true)]
    [TestCase(new[] { 1, 3, 4, 2, 2, 2, 1, 1, 2 }, true)]
    [TestCase(new[] { 1, 1, 1, 1, 1, 1 }, false)]
    [TestCase(new[] { 3, 1, 1, 1, 1, 1, 1, 2 }, true)]
    //[TestCase(new[] { 18, 12, -18, 18, -19, -1, 10, 10 }, true)]
    public void IsBalanced_WhenUniValued_ReturnTrue(int[] input, bool actual)
    {
        var helper = new JobTT();
        var expected = helper.IsBalanced(input);

        Assert.That(expected, Is.EqualTo(actual));
    }

    [Test]
    [TestCase(3, 2, new[] { 2, 1, 1, 0, 1 }, "11100,10001")]
    [TestCase(2, 3, new[] { 0, 0, 1, 1, 2 }, "IMPOSSIBLE")]
    [TestCase(2, 2, new[] { 2, 0, 2, 0 }, "1010,1010")]
    [TestCase(2, 2, new[] { 1, 1, 0, 2 }, "1001,0101")]
    [TestCase(3, 2, new[] { 1, 1, 1, 2 }, "1101,0011")]
    public void Matrix_WhenUniValued_ReturnExcepted(int u, int l, int[] input, string actual)
    {
        var helper = new JobTT();
        var expected = helper.Matrix(u, l, input);

        Assert.That(expected, Is.EqualTo(actual));
    }


    [Test]
    [TestCase(new[] { -1, 3, 3, 1 }, new[] { 2, -1 })]
    [TestCase(new[] { 2, 2, 2, -3 }, new[] { 1, -3 })]
    public void LatticePoint_WhenUniValued_ReturnExpected(int[] input, int[] actual)
    {
        var helper = new JobTT();
        var expected = helper.LatticePoint(input[0], input[1], input[2], input[3]);

        Assert.That(expected, Is.EqualTo(actual));
    }

    [Test]
    [TestCase("300.01", new[] { "300.00", "200.00", "100.00"}, new[] { "150.00", "100.00", "50.01" })]
    [TestCase("1.00", new[] { "0.05", "1.00"}, new[] { "0.05", "0.95" })]
    [TestCase("5.00", new[] { "1.00", "2.00", "2.00"}, new[] { "1.00", "2.00", "2.00" })]
    [TestCase("6.00", new[] { "1.00", "2.00", "2.00"}, new[] { "1.20", "2.40", "2.40" })]
    [TestCase("6.00", new[] { "0.00", "2.00", "2.00"}, new[] { "0.00", "3.00", "3.00" })]
    [TestCase("6.00", new[] { "1.00", "0.00", "2.00", "2.00"}, new[] { "1.20", "0.00", "2.40", "2.40" })]
    public void LatticePoint_WhenValued_ReturnExpected(string s,  string[] input, string[] actual)
    {
        var helper = new JobTT();
        var expected = helper.Allocation(s, input);

        Assert.That(expected, Is.EqualTo(actual));
    }
}
