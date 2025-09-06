public class Solution {
    public int CharacterReplacement(string s, int k) {
        var n = s.Length;
        var freq = new int[26];
        var maxLength = 0;
        var maxFreq = 0;
        var left = 0;

        for(int right = 0; right < n; right++)
        {
            freq[s[right] - 'A']++;

            maxFreq = Math.Max(maxFreq, freq[s[right] - 'A']);

            while(right - left + 1 - maxFreq > k)
            {
                freq[s[left] - 'A']--;
                left++;
            }
            
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}