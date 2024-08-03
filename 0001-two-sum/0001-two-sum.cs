public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        if(nums == null || nums.Length < 2)
            return null;
            
        Dictionary<int, int> map = new();
        for (var i = 0; i < nums.Length; i++)
        {
            var pair = target - nums[i];
            if (map.ContainsKey(pair))
                return new int [] {map[pair] ,i};
            
            map[nums[i]] = i;
        }
        return null; 
    }
}