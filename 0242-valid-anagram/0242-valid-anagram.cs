public class Solution {
    public bool IsAnagram(string s, string t) {
        
         if (s.Length != t.Length)
            return false;
        
        char[] source = s.ToCharArray(), target = t.ToCharArray();
        
        Array.Sort(source);
        Array.Sort(target);
        
        return Enumerable.SequenceEqual(source, target);
    }
}