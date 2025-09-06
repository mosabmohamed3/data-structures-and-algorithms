public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length > s2.Length)
            return false;

        var freq1 = new int[26];
        var freq2 = new int[26];

        foreach(var c in s1)
            freq1[c - 'a']++;
        
        var left = 0;
        for(var right=0; right<s2.Length; right++)
        {
            freq2[s2[right] - 'a']++;

            if(right - left + 1 > s1.Length)
            {
                freq2[s2[left] - 'a']--;
                left++;
            }

            if (freq1.SequenceEqual(freq2)) {
                return true;
            }
        }

        return false;
    }
}