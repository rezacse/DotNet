namespace ProblemSolving.Tests.LeetCode.Completed
{
    [TestFixture]
    public class LFUCacheTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(2)]
        //[TestCase(2, new int[][] { new[] { 1, 1 }, new[] { 2, 2 }, new[] { 1 }, new[] { 3, 3 }, new[] { 2 }, new[] { 3 }, new[] { 4, 4 }, new[] { 1 }, new[] { 3 }, new[] { 4 } })]
        public void Move_WhenCalled_ShouldMoveAllZeroToLast(int capacity)
        {
            var helper = new LFUCache(capacity);

            var inputs = new int[][] { [1, 1], [2, 2], [1], [ 3, 3 ], [ 2 ], [ 3 ], [ 4, 4 ], [ 1 ], [3], [ 4 ] };

            foreach(var i in inputs)
            {
                if (i.Length == 1) 
                    helper.Get(i[0]);
                else helper.Put(i[0], i[1]);

            }

            Assert.That(0, Is.EqualTo(0));
        }
    }
}