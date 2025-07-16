public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;

        var forS = s.ToCharArray();
        var forT = t.ToCharArray();

        var hashForS = new Dictionary<char, int>();
        var hashForT = new Dictionary<char, int>();

        for (var i = 0; i < forS.Length; i++)
        {
            var value1 = forS[i];
            var value2 = forT[i];

            if (!hashForS.ContainsKey(value1))
                hashForS[value1] = 1;
            else
                hashForS[value1]++;
       
            if (!hashForT.ContainsKey(value2))
                hashForT[value2] = 1;
            else
                hashForT[value2] ++;
        }

        if (hashForS.Count != hashForT.Count)
            return false;
        
        foreach (var kvp in hashForT)
        {
            var key = kvp.Key;
            var value = kvp.Value;

            if (!hashForS.ContainsKey(key) || hashForS[key] != value)
                return false;
        }    

        return true;
    }
}
