public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();

        foreach(var token in tokens)
        {
            if(token == "-" || token == "+" ||token == "*" ||token == "/")
            {
                var b = stack.Pop();
                var a = stack.Pop();

                if(token == "-")
                    stack.Push(a - b);
                else if(token == "+")
                    stack.Push(a + b);
                else if(token == "*")
                    stack.Push(a * b);
                else if(token == "/")
                    stack.Push(a / b);
            }
            else
            {
                stack.Push(int.Parse(token));
            }
        }

        return stack.Pop();
    }
}