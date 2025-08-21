public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var dic = new Dictionary<string, List<string>>();

        foreach(var str in strs)
        {
            var chars = str.ToCharArray();
            Array.Sort(chars);
            var key = new string(chars);

            if(!dic.ContainsKey(key))
                dic[key] = new List<string>();
          
            dic[key].Add(str);
        }   
        return dic.Values.ToList<IList<string>>();
    }
}