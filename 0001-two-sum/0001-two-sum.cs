public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        if(nums == null || nums.Length < 2)
            return null;
            
        for (int a = 0; a < nums.Length; a++)
        {
            for (int b = a + 1; b < nums.Length; b++)
            {
                if (nums[a] + nums[b] == target)
                    return new int[] { a, b };
            }
        }
        return null;
    }
}