namespace Programming.LeetCode.July
{

    //* Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class RemoveLinkedListElements
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            var cnode = head;
            while (cnode != null)
            {
                if (cnode.val == val)
                {
                    head = cnode.next;
                    cnode = head;
                    continue;
                }

                if (cnode.next != null && cnode.next.val == val) cnode.next = cnode.next.next;
                else cnode = cnode.next;
            }

            return head;
        }

    }
}
