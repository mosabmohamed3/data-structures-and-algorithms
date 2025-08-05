public class Solution {
    public bool IsPalindrome(string s) {
        var l = 0;
        var r = s.Length -1;

        while(l<r)
        {
            while(l<r && !char.IsLetterOrDigit(s[r]))
                r--;

            while(l<r && !char.IsLetterOrDigit(s[l]))
                l++;
            
            if(char.ToLower(s[r]) != char.ToLower(s[l]))
                return false;
            
            r--;
            l++;
        }

        return true;
    }
}