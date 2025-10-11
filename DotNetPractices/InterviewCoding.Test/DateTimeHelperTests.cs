using NUnit.Framework;

namespace InterviewCoding.Tests;

[TestFixture]
public class DateTimeHelperTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GetPayoutDate()
    {
        var helper = new DateTimeHelper();
        var d = helper.GetPayoutDate(DateTime.Now);


        d = helper.GetPayoutDate(DateTime.Now.AddDays(-4));

        d = helper.GetPayoutDate(DateTime.Now.AddDays(-5));

        d = helper.GetPayoutDate(DateTime.Now.AddDays(3));

        d = helper.GetPayoutDate(DateTime.Now.AddDays(4));

    }
}
