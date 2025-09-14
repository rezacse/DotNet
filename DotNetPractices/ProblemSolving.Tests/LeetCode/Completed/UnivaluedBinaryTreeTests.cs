using NUnit.Framework;
using Programming.LeetCode.AugustPractics;

namespace ProgrammingTests.LeetCode.Completed
{

    [TestFixture]
    public class UnivaluedBinaryTreeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BinaryTreeTilt_WhenUniValued_ReturnTrue()
        {
            var helper = new UnivaluedBinaryTree();
            var root = new TreeNode
            {
                val = 1,
                left = new TreeNode
                {
                    val = 1,
                },
                right = new TreeNode
                {
                    val = 1,
                }
            };


            var result = helper.IsUnivalTree(root);

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void BinaryTreeTilt_WhenNotUniValued_ReturnFalse()
        {
            var helper = new UnivaluedBinaryTree();
            var root = new TreeNode
            {
                val = 1,
                left = new TreeNode
                {
                    val = 1,
                    left = new TreeNode
                    {
                        val = 4
                    }
                },
                right = new TreeNode
                {
                    val = 1
                }
            };


            var result = helper.IsUnivalTree(root);

            Assert.That(result, Is.EqualTo(false));
        }
    }
}
