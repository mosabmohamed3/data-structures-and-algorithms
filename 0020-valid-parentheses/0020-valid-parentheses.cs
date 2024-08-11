public class Solution {
    public bool IsValid(string s) {
        if (s == null || s.Length == 1)
            return false;

        Stack<char> stack = new();
        Dictionary<char, char> map = new();

        map.Add(')', '(');
        map.Add('}', '{');
        map.Add(']', '[');


        foreach (var letter in s)
        {
            if (!map.ContainsKey(letter))
            {
                stack.Push(letter);
            }
            else
            {
                if (stack.Count == 0)
                    return false;

                var open = stack.Pop();
                var openValue = map[letter];

                if (open != openValue)
                    return false;
            }
        }

        return stack.Count == 0;
    }
}