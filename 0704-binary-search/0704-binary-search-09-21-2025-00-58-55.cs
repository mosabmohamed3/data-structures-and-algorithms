public class Solution {
    public int Search(int[] nums, int target) {
        int r = nums.Length - 1, l = 0;

        while(l <= r)
        {
            int m = l + (r-l / 2);
            if(nums[m] == target)
                return m;
            else if(nums[m] < target)
                l = m + 1;
            else if(nums[m] > target)
                r = m - 1;
        }
        return -1;
    }
}