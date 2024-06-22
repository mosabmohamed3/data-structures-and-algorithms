public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        HashSet<int> hashSet = new HashSet<int>();
        
        foreach(int num in nums)
        {
            if (hashSet.Contains(num))
                return true;
                
            hashSet.Add(num);
        }
        
        return false;
    }
}