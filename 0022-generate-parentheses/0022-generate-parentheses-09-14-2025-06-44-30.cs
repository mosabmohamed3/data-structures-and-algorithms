public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        var result = new List<string>();

        var stack = new Stack<(string current, int open, int close)>();
        stack.Push(("", 0,0));

        while(stack.Count > 0)
        {
            var (current, open, close) = stack.Pop();

            if (current.Length == n * 2)
            {
                result.Add(current);
                continue;
            }
            
            if (open < n)
                stack.Push((current + '(', open+1, close));

            if (close < open)
                stack.Push((current + ')', open, close+1));
        }

        return result;
    }
}