public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        var result = new List<string>();
        
        // Stack will store tuples (currentString, openCount, closeCount)
        var stack = new Stack<(string current, int open, int close)>();
        stack.Push(("", 0, 0)); // Start with empty string and no parentheses used

        while (stack.Count > 0) {
            var (current, open, close) = stack.Pop();

            // If we've used all parentheses
            if (current.Length == 2 * n) {
                result.Add(current);
                continue;
            }

            // If we can still add '('
            if (open < n) {
                stack.Push((current + "(", open + 1, close));
            }

            // If we can add ')' without breaking balance
            if (close < open) {
                stack.Push((current + ")", open, close + 1));
            }
        }

        return result;
    }
}