using System.Collections;

namespace Programming.Codility
{
    class Bracket
    {
        public int Solution(string S)
        {
            if (string.IsNullOrEmpty(S)) return 1;
            else if (S.Length % 2 != 0) return 0;

            var stack = new Stack();
            foreach (var s in S)
            {
                if (stack.Count > 0 && ShouldPop((char)stack.Peek(), s))
                {
                    stack.Pop();
                }
                else stack.Push(s);
            }

            return stack.Count == 0 ? 1 : 0;
        }

        bool ShouldPop(char f, char l)
        {
            if (f == '(' && l == ')') return true;
            if (f == '{' && l == '}') return true;
            if (f == '[' && l == ']') return true;

            return false;
        }
    }
}
