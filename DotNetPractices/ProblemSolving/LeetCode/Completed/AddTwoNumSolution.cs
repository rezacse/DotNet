namespace ProblemSolving.LeetCode.Completed;

    public class AListNode
    {
        public int val;
        public AListNode next;
        public AListNode(int val = 0, AListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        //public override bool Equals(AListNode obj)
        //{
        //    return obj.val == val && obj.next == next;
        //}
        //public override int GetHashCode()
        //{
        //    return re.GetHashCode() ^ im.GetHashCode();
        //}
    }

    public class AddTwoNumSolution
    {
        public AListNode AddTwoNumbers(AListNode l1, AListNode l2)
        {
            var c = l1.val + l2.val;
            var ls = new AListNode(c % 10);
            c /= 10;
            var t = ls;
            while (l1.next != null || l2.next != null)
            {
                if (l1.next != null)
                {
                    c += l1.next.val;
                    l1 = l1.next;
                }
                if (l2.next != null)
                {
                    c += l2.next.val;
                    l2 = l2.next;
                }

                t.next = new AListNode(c % 10);
                t = t.next;
                c /= 10;
            }

            if (c > 0) t.next = new AListNode(c);
            return ls;
        }
    }
