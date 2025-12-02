public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int max = 0, l = 0;
        var set = new HashSet<char>();

        for(var r=0; r<s.Length; r++)
        {
            while(set.Contains(s[r]))
            {
                set.Remove(s[l]);
                l++;
            }
            
            set.Add(s[r]);

            max = Math.Max(max, r-l+1);
        }

        return max;
    }
}