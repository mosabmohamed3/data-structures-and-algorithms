public class Solution {
    public bool IsValid(string s) {
        var dic = new Dictionary<char,char>(){
            {')','('},
            {'}','{'},
            {']','['}
        };

        var stack = new Stack<char>();

        foreach(char c in s)
        {
                
            if(!dic.ContainsKey(c))
            {
                stack.Push(c);
                continue;
            }

            if(stack.Count == 0)
                return false;
                
            var open = stack.Pop();
            if(dic[c] != open)
                return false;
        }

        return stack.Count == 0;
    }
}