using NUnit.Framework;
using Programming.LeetCode.July;

namespace ProgrammingTests.LeetCode.Completed
{
    [TestFixture]
    public class RemoveLinkedListElementsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RemoveElements_WhenMiddleAndEnd_ReturnExpected()
        {
            var helper = new RemoveLinkedListElements();
            //1->2->6->3->4->5->6, val = 6

            var head = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(6)
                    {
                        next = new ListNode(3)
                        {
                            next = new ListNode(4)
                            {
                                next = new ListNode(5)
                                {
                                    next = new ListNode(6)
                                }
                            }
                        }
                    }
                }
            };

            var expected = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            };

            var result = helper.RemoveElements(head, 6);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void RemoveElements_WhenFromStart_ReturnExpected()
        {
            var helper = new RemoveLinkedListElements();
            //1->2->6->3->4->5->6, val = 6

            var head = new ListNode(1)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(3)
                        {
                            next = new ListNode(4)
                            {
                                next = new ListNode(5)
                            }
                        }
                    }
                }
            };

            var expected = new ListNode(2)
            {
                next = new ListNode(3)
                {
                    next = new ListNode(4)
                    {
                        next = new ListNode(5)
                    }
                }
            };

            var result = helper.RemoveElements(head, 1);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void RemoveElements_MiddleConsequitive_ReturnExpected()
        {
            var helper = new RemoveLinkedListElements();
            //1->2->6->3->4->5->6, val = 6

            var head = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(1)
                    }
                }
            };

            var expected = new ListNode(1)
            {
                next = new ListNode(1)
            };

            var result = helper.RemoveElements(head, 2);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
