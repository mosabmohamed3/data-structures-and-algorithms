public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();
        
        foreach (var str in strs)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string sorted = new string(chars);
            
            if(!anagrams.ContainsKey(sorted))
                anagrams[sorted] = new List<string>();
            
            anagrams[sorted].Add(str);
        }
        
        return anagrams.Select(kv => kv.Value).ToList<IList<string>>();
//         List<List<string>> Result;
        
//         List<List<Char>> charsOfWords;
        
//         for(var i = 0; i < strs.Length; i++)
//         {
//             var strToChars = strs[i].ToCharArray();
//             Array.Sort(strToChars);
//             charsOfWords.add(strToChars);
//         }
        
//         for(var i = 0; i < charsOfWords.Length; i++)
//         {
//             List<string> ListOfAnagram;
//             ListOfAnagram.add(charsOfWords[i].ToString());
//             for(var j = i + 1; j < charsOfWords.Length; j++)
//             {
//                  if(Enumerable.SequenceEqual(charsOfWords[i], charsOfWords[j]))
//                         ListOfAnagram.add(charsOfWords[j].ToString());
//             }
//             Result.Add(ListOfAnagram);
//         }
    }
}