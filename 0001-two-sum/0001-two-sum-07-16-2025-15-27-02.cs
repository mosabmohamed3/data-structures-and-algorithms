public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dic = new Dictionary<int, int>();

        for(var i = 0; i < nums.Length; i++)
        {
            var remaining = target - nums[i];
            if (dic.ContainsKey(remaining))
                return new int[] { i, dic[remaining]};
            
            dic[nums[i]] = i;
        }

        return default;
    }
}