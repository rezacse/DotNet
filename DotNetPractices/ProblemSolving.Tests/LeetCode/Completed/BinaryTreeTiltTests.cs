using NUnit.Framework;
using Programming.LeetCode.AugustPractics;

namespace ProgrammingTests.LeetCode.Completed
{
    [TestFixture]
    public class BinaryTreeTiltTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BinaryTreeTilt_When2Level_ReturnExpected()
        {
            var helper = new BinaryTreeTilt();
            var root = new TreeNode
            {
                val = 1,
                left = new TreeNode
                {
                    val = 2,
                },
                right = new TreeNode
                {
                    val = 3,
                }
            };


            var result = helper.FindTilt(root);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void BinaryTreeTilt_When3Level_ReturnExpected()
        {
            var helper = new BinaryTreeTilt();
            var root = new TreeNode
            {
                val = 1,
                left = new TreeNode
                {
                    val = 2,
                    left = new TreeNode
                    {
                        val = 4
                    },
                    right = new TreeNode
                    {
                        val = 5
                    }
                },
                right = new TreeNode
                {
                    val = 3,
                    left = new TreeNode
                    {
                        val = 6
                    },
                    right = new TreeNode
                    {
                        val = 7
                    }
                }
            };


            var result = helper.FindTilt(root);

            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void BinaryTreeTilt_WhenNotCompleteBinary_ReturnExpected()
        {
            var helper = new BinaryTreeTilt();
            var root = new TreeNode
            {
                val = 4,
                left = new TreeNode
                {
                    val = 2,
                    left = new TreeNode
                    {
                        val = 3
                    },
                    right = new TreeNode
                    {
                        val = 5
                    }
                },
                right = new TreeNode
                {
                    val = 9,
                    left = new TreeNode
                    {
                        val = 7
                    }
                }
            };


            var result = helper.FindTilt(root);

            Assert.That(result, Is.EqualTo(15));
        }

    }
}
