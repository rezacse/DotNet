using NUnit.Framework;
using Programming.LeetCode.AugustPractics;
using Programming.LeetCode.OctoberPractics;
using System.Collections.Generic;

namespace ProgrammingTests.LeetCode.Completed
{
    [TestFixture]
    public class PreorderTraversalSolutionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        #region Preorder
        [Test]
        public void PreorderTraversal_Empty_ReturnEmpty()
        {
            var helper = new TreeTraversalSolution();
            TreeNode root = null;

            var result = helper.PreorderTraversal(root);

            Assert.That(result, Is.EqualTo(new List<int> { }));
        }

        [Test]
        public void PreorderTraversal_SingleItem_ReturnExpected()
        {
            var helper = new TreeTraversalSolution();
            var root = new TreeNode
            {
                val = 1
            };


            var result = helper.PreorderTraversal(root);

            Assert.That(result, Is.EqualTo(new List<int> { 1 }));
        }


        [Test]
        public void PreorderTraversal_WhenLeftNull_ReturnExpected()
        {
            var helper = new TreeTraversalSolution();
            var root = new TreeNode
            {
                val = 1,
                left = null,
                right = new TreeNode
                {
                    val = 2
                }
            };


            var result = helper.PreorderTraversal(root);

            Assert.That(result, Is.EqualTo(new List<int> { 1, 2 }));
        }

        [Test]
        public void PreorderTraversal_WhenRightNull_ReturnExpected()
        {
            var helper = new TreeTraversalSolution();
            var root = new TreeNode
            {
                val = 1,
                right = null,
                left = new TreeNode
                {
                    val = 2
                }
            };


            var result = helper.PreorderTraversal(root);

            Assert.That(result, Is.EqualTo(new List<int> { 1, 2 }));
        }

        [Test]
        public void PreorderTraversal_CompleteBTree_ReturnExpected()
        {
            var helper = new TreeTraversalSolution();
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


            var result = helper.PreorderTraversal(root);

            Assert.That(result, Is.EqualTo(new List<int> { 1, 2, 3 }));
        }



        [Test]
        public void PreorderTraversal_NullFixed_ReturnExpected()
        {
            var helper = new TreeTraversalSolution();
            var root = new TreeNode
            {
                val = 1,
                left = new TreeNode
                {
                    val = 2,
                    right = new TreeNode
                    {
                        val = 3,
                        left = new TreeNode
                        {
                            val = 4,
                        }
                    }
                },
                right = new TreeNode
                {
                    val = 5,
                    right = new TreeNode
                    {
                        val = 6,
                        left = new TreeNode
                        {
                            val = 7,
                        },
                        right = new TreeNode
                        {
                            val = 8,
                        }
                    }
                }
            };


            var result = helper.PreorderTraversal(root);

            Assert.That(result, Is.EqualTo(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 }));
        }
        #endregion

        #region Inorder
        [Test]
        public void InorderTraversal_Empty_ReturnEmpty()
        {
            var helper = new TreeTraversalSolution();
            TreeNode root = null;

            var result = helper.InorderTraversal(root);

            Assert.That(result, Is.EqualTo(new List<int> { }));
        }

        [Test]
        public void InorderTraversal_SingleItem_ReturnExpected()
        {
            var helper = new TreeTraversalSolution();
            var root = new TreeNode
            {
                val = 1
            };

            var result = helper.InorderTraversal(root);

            Assert.That(result, Is.EqualTo(new List<int> { 1 }));
        }


        [Test]
        public void InorderTraversal_WhenLeftNull_ReturnExpected()
        {
            var helper = new TreeTraversalSolution();
            var root = new TreeNode
            {
                val = 1,
                left = null,
                right = new TreeNode
                {
                    val = 2
                }
            };


            var result = helper.InorderTraversal(root);

            Assert.That(result, Is.EqualTo(new List<int> { 1, 2 }));
        }

        [Test]
        public void InorderTraversal_WhenRightNull_ReturnExpected()
        {
            var helper = new TreeTraversalSolution();
            var root = new TreeNode
            {
                val = 1,
                left = new TreeNode
                {
                    val = 2
                },
                right = null
            };


            var result = helper.InorderTraversal(root);

            Assert.That(result, Is.EqualTo(new List<int> { 2, 1 }));
        }

        [Test]
        public void InorderTraversal_CompleteBTree_ReturnExpected()
        {
            var helper = new TreeTraversalSolution();
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


            var result = helper.InorderTraversal(root);

            Assert.That(result, Is.EqualTo(new List<int> { 2, 1, 3 }));
        }



        [Test]
        public void InorderTraversal_NullFixed_ReturnExpected()
        {
            var helper = new TreeTraversalSolution();
            var root = new TreeNode
            {
                val = 1,
                left = new TreeNode
                {
                    val = 2,
                    right = new TreeNode
                    {
                        val = 3,
                        left = new TreeNode
                        {
                            val = 4,
                        }
                    }
                },
                right = new TreeNode
                {
                    val = 5,
                    right = new TreeNode
                    {
                        val = 6,
                        left = new TreeNode
                        {
                            val = 7,
                        },
                        right = new TreeNode
                        {
                            val = 8,
                        }
                    }
                }
            };


            var result = helper.InorderTraversal(root);

            Assert.That(result, Is.EqualTo(new List<int> { 2, 4, 3, 1, 5, 7, 6, 8 }));
        }
        #endregion


        #region Post
        [Test]
        public void PostorderTraversal_Empty_ReturnEmpty()
        {
            var helper = new TreeTraversalSolution();
            TreeNode root = null;

            var result = helper.PostorderTraversal(root);

            Assert.That(result, Is.EqualTo(new List<int> { }));
        }

        [Test]
        public void PostorderTraversal_SingleItem_ReturnExpected()
        {
            var helper = new TreeTraversalSolution();
            var root = new TreeNode
            {
                val = 1
            };

            var result = helper.PostorderTraversal(root);

            Assert.That(result, Is.EqualTo(new List<int> { 1 }));
        }


        [Test]
        public void PostorderTraversal_WhenLeftNull_ReturnExpected()
        {
            var helper = new TreeTraversalSolution();
            var root = new TreeNode
            {
                val = 1,
                left = null,
                right = new TreeNode
                {
                    val = 2
                }
            };


            var result = helper.PostorderTraversal(root);

            Assert.That(result, Is.EqualTo(new List<int> { 2, 1 }));
        }

        [Test]
        public void PostorderTraversal_WhenRightNull_ReturnExpected()
        {
            var helper = new TreeTraversalSolution();
            var root = new TreeNode
            {
                val = 1,
                left = new TreeNode
                {
                    val = 2
                },
                right = null
            };


            var result = helper.PostorderTraversal(root);

            Assert.That(result, Is.EqualTo(new List<int> { 2, 1 }));
        }

        [Test]
        public void PostorderTraversal_CompleteBTree_ReturnExpected()
        {
            var helper = new TreeTraversalSolution();
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


            var result = helper.PostorderTraversal(root);

            Assert.That(result, Is.EqualTo(new List<int> { 2, 3, 1 }));
        }



        [Test]
        public void PostorderTraversal_NullFixed_ReturnExpected()
        {
            var helper = new TreeTraversalSolution();
            var root = new TreeNode
            {
                val = 1,
                left = new TreeNode
                {
                    val = 2,
                    right = new TreeNode
                    {
                        val = 3,
                        left = new TreeNode
                        {
                            val = 4,
                        }
                    }
                },
                right = new TreeNode
                {
                    val = 5,
                    right = new TreeNode
                    {
                        val = 6,
                        left = new TreeNode
                        {
                            val = 7,
                        },
                        right = new TreeNode
                        {
                            val = 8,
                        }
                    }
                }
            };

            var result = helper.PostorderTraversal(root);

            Assert.That(result, Is.EqualTo(new List<int> { 4, 3, 2, 7, 8, 6, 5, 1 }));
        }
        #endregion

    }
}
