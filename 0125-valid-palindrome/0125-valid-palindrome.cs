public class Solution {
    public bool IsPalindrome(string s) {
        var l = 0;
        var r = s.Length - 1;

        while(r>l)
        {
            while(r>l && !char.IsLetterOrDigit(s[l]))
                l++;
            
            while(r>l && !char.IsLetterOrDigit(s[r]))
                r--;

            if(char.ToLower(s[l]) != char.ToLower(s[r]))
                return false;
            
            l++;
            r--;
        }

        return true;
    }
}